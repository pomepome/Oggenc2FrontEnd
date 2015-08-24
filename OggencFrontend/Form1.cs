﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CSCore;
using CSCore.MediaFoundation;
using OggencFrontend.Properties;
using TagLib;
using System.Collections.Generic;

namespace OggencFrontend
{
    public partial class Form1 : Form
    {

        Setting setting = new Setting();

        bool isBitrate, useTag, useSampling;
        int level, samplingRate;
        double bitrate, volume;

        string runDir; 

        public Form1()
        {
            InitializeComponent();
            AddOwnedForm(setting);
            setting.setMainForm(this);
            openAudio.Filter = "Supported Formats(*.wav *.mp3 *.flac *.aac *.m4a *.wma)|*.wav;*.mp3;*.flac;*.aac;*.m4a;*.wma|Wave audio(*.wav)|*.wav|Mpeg-1 Layer3 audio(*.mp3)|*.mp3|Free Lossless Audio(*.flac)|*.flac|Advanced Audio Codec(*.aac,*.m4a)|*.aac;*.m4a|Windows Media Audio(*.wma)|*.wma";
        }

        public void setSettings(bool is_Bitrate,bool use_tag,int lev,int sampling_rate,double bit_rate,bool useSamplingRate,double volume,string oggenc)
        {
            isBitrate = is_Bitrate;
            useTag = use_tag;
            level = lev;
            samplingRate = sampling_rate;
            bitrate = bit_rate;
            useSampling = useSamplingRate;
            this.volume = volume;
            runDir = oggenc;
            saveSettings();
        }
        public void resetSettings()
        {
            isBitrate = false;
            useTag = true;
            level = 3;
            samplingRate = 44100;
            bitrate = 128;
            useSampling = false;
            volume = 1;
            runDir = "";
            saveSettings();
        }
        private void Decode(string filePath)
        {
            if (!Directory.Exists("temp"))
            {
                Directory.CreateDirectory("temp");
            }
            {
                string toOut = @"temp\" + Path.GetFileNameWithoutExtension(filePath) + ".wav";
                using (var decoder = new MediaFoundationDecoder(filePath))
                {
                    decoder.WriteToFile(toOut);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setting.setSettings(isBitrate, level, bitrate, samplingRate, useTag, useSampling, volume, runDir);
            setting.ShowDialog();
        }

        private void saveSettings()
        {
            Settings s = getSettings();
            s.isBitrate = isBitrate;
            s.Level = level;
            s.Bitrate = bitrate;
            s.SamplingRate = samplingRate;
            s.useTag = useTag;
            s.OggencPath = runDir;
            s.useSampling = useSampling;
            s.Volume = volume;
            s.Save();
        }

        private void openAudio_FileOk(object sender, CancelEventArgs e)
        {
            string[] pathes = openAudio.FileNames;
            foreach(string path in pathes)
            {
                if (!listBox1.Items.Contains(path))
                {
                    listBox1.Items.Add(path);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while(listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openAudio.ShowDialog();
        }

        private string deleteSpace(string src)
        {
            return src.Replace(" ", "_").Replace("　","_");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("out"))
            {
                Directory.CreateDirectory("out");
            }
            process();
        }
        private void process()
        {
            if (listBox1.Items.Count > 0)
            {
                string path = listBox1.Items[0].ToString();
                string baseName = Path.GetFileNameWithoutExtension(path);
                string option = "";
                bool doDecode = true;
                string toEncode = "\"" + path + "\"";

                if (System.IO.File.Exists(path))
                {
                    if (Path.GetExtension(path) == ".wav")
                    {
                        doDecode = false;
                    }
                    else
                    {
                        if (useTag)
                        {
                            TagLib.File tagFile = TagLib.File.Create(path);
                            Tag tag = tagFile.Tag;
                            if (tag != null)
                            {
                                if (tag.Comment != null)
                                {
                                    option += String.Format(" --comment comment=\"{0}", tag.Comment) + "\"";
                                }
                                if (tag.Performers != null && (tag.Performers.Length > 0 || tag.JoinedPerformers != null))
                                {
                                    option += " --artist \"";
                                    List<string> artistList = new List<string>();
                                    foreach(string performer in tag.Performers)
                                    {
                                        if(performer.Trim() != "" && !artistList.Contains(performer))
                                        {
                                            artistList.Add(performer);
                                        }
                                    }
                                    if(tag.JoinedPerformers != null && tag.JoinedPerformers.Trim() != "")
                                    {
                                        string[] performers = tag.JoinedPerformers.Split(";".ToCharArray());
                                        foreach(string performer in performers)
                                        {
                                            if(performer.Trim() != "" && !artistList.Contains(performer))
                                            {
                                                artistList.Add(performer.Trim());
                                            }
                                        }
                                    }
                                    foreach (string artist in artistList)
                                    {
                                        option += artist + ";";
                                    }
                                    option = option.Remove(option.Length - 1);
                                    option += "\"";
                                }
                                if (tag.FirstGenre != null)
                                {
                                    option += String.Format(" --genre \"{0}", tag.FirstGenre) + "\"";
                                }
                                if (tag.Year != 0)
                                {
                                    option += String.Format(" --date \"{0}", tag.Year) + "\"";
                                }
                                if (tag.Track != 0)
                                {
                                    option += String.Format(" --tracknum \"{0}", tag.Track) + "\"";
                                }
                                if (tag.Title != null)
                                {
                                    option += String.Format(" --title \"{0}", tag.Title) + "\"";
                                }
                                if (tag.Album != null)
                                {
                                    option += String.Format(" --album \"{0}", tag.Album) + "\"";
                                }
                            }
                        }
                    }
                    if (doDecode)
                    {
                        toEncode = "\"temp\\" + baseName + ".wav\"";
                        Decode(path);
                    }

                    {
                        if (isBitrate)
                        {
                            option += String.Format(" --bitrate {0}", bitrate);
                        }
                        else
                        {
                            option += String.Format(" --quality {0}", level);
                        }
                        if (useSampling)
                        {
                            option += String.Format(" --resample {0}", samplingRate);
                        }
                        option += String.Format(" --scale {0}",volume);
                    }
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = runDir;
                    psi.UseShellExecute = true;
                    psi.Arguments = toEncode + option + " -o " + "\"out\\" + baseName + ".ogg ";

                    Process p = Process.Start(psi);
                    p.WaitForExit();

                    if (doDecode)
                    {
                        System.IO.File.Delete(@"temp\" + baseName + ".wav");
                        Directory.Delete(@"temp\");
                    }
                    listBox1.Items.RemoveAt(0);
                    if (listBox1.Items.Count > 0)
                    {
                        process();
                    }
                }
                else
                {
                    MessageBox.Show(this, "ファイルが見つかりませんでした:" + Path.GetFileName(path), "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBox1.Items.RemoveAt(0);
                }
            }
        }

        private void openOggEnc_FileOk(object sender, CancelEventArgs e)
        {
            runDir = openOggEnc.FileName;
            saveSettings();
        }

        private Settings getSettings()
        {
            return Settings.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings s = getSettings();
            isBitrate = s.isBitrate;
            useTag = s.useTag;
            level = s.Level;
            samplingRate = s.SamplingRate;
            bitrate = s.Bitrate;
            runDir = s.OggencPath;
            useSampling = s.useSampling;
            volume = s.Volume;
            if(runDir == "")
            {
                DialogResult result = openOggEnc.ShowDialog();
                if(result == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
