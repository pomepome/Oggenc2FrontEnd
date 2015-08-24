namespace OggencFrontend
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBitrate = new System.Windows.Forms.NumericUpDown();
            this.numericLevel = new System.Windows.Forms.NumericUpDown();
            this.bitrateBox = new System.Windows.Forms.RadioButton();
            this.levelBox = new System.Windows.Forms.RadioButton();
            this.checkTag = new System.Windows.Forms.CheckBox();
            this.comboSampling = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkSampling = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericVolume = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.openOggenc = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericBitrate);
            this.groupBox1.Controls.Add(this.numericLevel);
            this.groupBox1.Controls.Add(this.bitrateBox);
            this.groupBox1.Controls.Add(this.levelBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "品質";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "kbps";
            // 
            // numericBitrate
            // 
            this.numericBitrate.DecimalPlaces = 1;
            this.numericBitrate.Enabled = false;
            this.numericBitrate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericBitrate.Location = new System.Drawing.Point(105, 53);
            this.numericBitrate.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericBitrate.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericBitrate.Name = "numericBitrate";
            this.numericBitrate.Size = new System.Drawing.Size(69, 19);
            this.numericBitrate.TabIndex = 3;
            this.numericBitrate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericLevel
            // 
            this.numericLevel.Location = new System.Drawing.Point(105, 19);
            this.numericLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericLevel.Name = "numericLevel";
            this.numericLevel.Size = new System.Drawing.Size(69, 19);
            this.numericLevel.TabIndex = 2;
            // 
            // bitrateBox
            // 
            this.bitrateBox.AutoSize = true;
            this.bitrateBox.Location = new System.Drawing.Point(7, 53);
            this.bitrateBox.Name = "bitrateBox";
            this.bitrateBox.Size = new System.Drawing.Size(73, 16);
            this.bitrateBox.TabIndex = 1;
            this.bitrateBox.Text = "ビットレート";
            this.bitrateBox.UseVisualStyleBackColor = true;
            // 
            // levelBox
            // 
            this.levelBox.AutoSize = true;
            this.levelBox.Checked = true;
            this.levelBox.Location = new System.Drawing.Point(7, 19);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(52, 16);
            this.levelBox.TabIndex = 0;
            this.levelBox.TabStop = true;
            this.levelBox.Text = "レベル";
            this.levelBox.UseVisualStyleBackColor = true;
            this.levelBox.CheckedChanged += new System.EventHandler(this.levelBox_CheckedChanged);
            // 
            // checkTag
            // 
            this.checkTag.AutoSize = true;
            this.checkTag.Location = new System.Drawing.Point(12, 187);
            this.checkTag.Name = "checkTag";
            this.checkTag.Size = new System.Drawing.Size(222, 16);
            this.checkTag.TabIndex = 1;
            this.checkTag.Text = "自動的にタグを検出する(利用できる場合)";
            this.checkTag.UseVisualStyleBackColor = true;
            // 
            // comboSampling
            // 
            this.comboSampling.Enabled = false;
            this.comboSampling.FormattingEnabled = true;
            this.comboSampling.Items.AddRange(new object[] {
            "8000",
            "11025",
            "16000",
            "22050",
            "32000",
            "44100",
            "48000"});
            this.comboSampling.Location = new System.Drawing.Point(131, 155);
            this.comboSampling.Name = "comboSampling";
            this.comboSampling.Size = new System.Drawing.Size(104, 20);
            this.comboSampling.TabIndex = 4;
            this.comboSampling.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(160, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkSampling
            // 
            this.checkSampling.AutoSize = true;
            this.checkSampling.Location = new System.Drawing.Point(12, 158);
            this.checkSampling.Name = "checkSampling";
            this.checkSampling.Size = new System.Drawing.Size(113, 16);
            this.checkSampling.TabIndex = 8;
            this.checkSampling.Text = "サンプリング周波数";
            this.checkSampling.UseVisualStyleBackColor = true;
            this.checkSampling.CheckedChanged += new System.EventHandler(this.checkSampling_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "音量";
            // 
            // numericVolume
            // 
            this.numericVolume.Location = new System.Drawing.Point(52, 123);
            this.numericVolume.Name = "numericVolume";
            this.numericVolume.Size = new System.Drawing.Size(58, 19);
            this.numericVolume.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "%";
            // 
            // openOggenc
            // 
            this.openOggenc.FileName = "oggenc2.exe";
            this.openOggenc.Filter = "Ogg Encoder(oggenc2.exe)|oggenc2.exe";
            this.openOggenc.FileOk += new System.ComponentModel.CancelEventHandler(this.openOggenc_FileOk);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Oggenc2.exe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(269, 19);
            this.textBox1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 15;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Setting
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(402, 279);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericVolume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkSampling);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSampling);
            this.Controls.Add(this.checkTag);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bitrateBox;
        private System.Windows.Forms.RadioButton levelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBitrate;
        private System.Windows.Forms.NumericUpDown numericLevel;
        private System.Windows.Forms.CheckBox checkTag;
        private System.Windows.Forms.ComboBox comboSampling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkSampling;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openOggenc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}