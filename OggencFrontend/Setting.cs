using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OggencFrontend
{
    public partial class Setting : Form
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        Form1 mainForm;

        public Setting()
        {
            InitializeComponent();
            for(int i = 0;i < comboSampling.Items.Count;i++)
            {
                dic[comboSampling.Items[i].ToString()] = i;
            }
        }

        public void setMainForm(Form1 main)
        {
            mainForm = main;
        }

        public void setSettings(bool isBitrate,int level,double bitrate,int samplingRate,bool useTag,bool useSampling,double volume,string oggenc)
        {
            levelBox.Checked = !isBitrate;
            bitrateBox.Checked = isBitrate;
            numericLevel.Enabled = !isBitrate;
            numericBitrate.Enabled = isBitrate;
            comboSampling.Enabled = useSampling;
            comboSampling.SelectedIndex = dic[samplingRate.ToString()];
            checkSampling.Checked = useSampling;
            checkTag.Checked = useTag;
            if ((decimal)bitrate < numericBitrate.Minimum)
            {
                bitrate = (double)numericBitrate.Minimum;
            }
            numericBitrate.Value = (decimal)bitrate;
            numericLevel.Value = level;
            if((decimal)(volume * 100) > numericVolume.Maximum)
            {
                volume = (double)numericVolume.Maximum / 100;
            }
            numericVolume.Value = (decimal)volume * 100;
            textBox1.Text = oggenc;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            comboSampling.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void levelBox_CheckedChanged(object sender, EventArgs e)
        {
            numericLevel.Enabled = levelBox.Checked;
            numericBitrate.Enabled = !levelBox.Checked;
        }

        public int getSamplingRate()
        {
            string s = comboSampling.SelectedItem.ToString();
            return Convert.ToInt32(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.setSettings(bitrateBox.Checked, checkTag.Checked,(int)numericLevel.Value, getSamplingRate(), (double)numericBitrate.Value, checkSampling.Checked, ((double)numericVolume.Value) / 100, textBox1.Text);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkSampling_CheckedChanged(object sender, EventArgs e)
        {
            comboSampling.Enabled = checkSampling.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openOggenc.ShowDialog();
        }

        private void openOggenc_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openOggenc.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this,"Are you sure you want to reset settings and quit?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                mainForm.resetSettings();
                mainForm.Close();
            }
        }
    }
}
