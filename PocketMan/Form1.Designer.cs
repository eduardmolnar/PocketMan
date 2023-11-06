namespace PocketMan
{
    partial class PocketMan
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
            this.mainWindowTab = new System.Windows.Forms.TabControl();
            this.Info = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Audio = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.freq = new System.Windows.Forms.TabPage();
            this.Other = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainWindowTab.SuspendLayout();
            this.Info.SuspendLayout();
            this.Audio.SuspendLayout();
            this.Other.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowTab
            // 
            this.mainWindowTab.Controls.Add(this.Info);
            this.mainWindowTab.Controls.Add(this.Audio);
            this.mainWindowTab.Controls.Add(this.freq);
            this.mainWindowTab.Controls.Add(this.Other);
            this.mainWindowTab.Location = new System.Drawing.Point(0, 0);
            this.mainWindowTab.Name = "mainWindowTab";
            this.mainWindowTab.SelectedIndex = 0;
            this.mainWindowTab.Size = new System.Drawing.Size(240, 294);
            this.mainWindowTab.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.label1);
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(240, 271);
            this.Info.Text = "Info";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 164);
            this.label1.Text = "PocketMan Developer Build\r\nPre-alpha 1\r\n\r\nCurrently working:\r\n - Audio Player\r\n  " +
                "  - SystemSounds\r\n    - WAV file";
            // 
            // Audio
            // 
            this.Audio.Controls.Add(this.button2);
            this.Audio.Controls.Add(this.button3);
            this.Audio.Controls.Add(this.label4);
            this.Audio.Controls.Add(this.label3);
            this.Audio.Controls.Add(this.label2);
            this.Audio.Controls.Add(this.button1);
            this.Audio.Controls.Add(this.radioButton2);
            this.Audio.Controls.Add(this.radioButton1);
            this.Audio.Location = new System.Drawing.Point(0, 0);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(240, 271);
            this.Audio.Text = "Audio Player";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Stop";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "Select...";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 73);
            this.label4.Text = "No file playing.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "WAV Audio";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "SystemSounds";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(7, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "Asterisk";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Beep";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // freq
            // 
            this.freq.Location = new System.Drawing.Point(0, 0);
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(232, 268);
            this.freq.Text = "Freq";
            // 
            // Other
            // 
            this.Other.Controls.Add(this.label5);
            this.Other.Location = new System.Drawing.Point(0, 0);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(232, 268);
            this.Other.Text = "Other";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Beam with IrDA";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PocketMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.mainWindowTab);
            this.KeyPreview = true;
            this.Name = "PocketMan";
            this.Text = "Welcome";
            this.mainWindowTab.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Audio.ResumeLayout(false);
            this.Other.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainWindowTab;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.TabPage Audio;
        private System.Windows.Forms.TabPage Other;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage freq;
    }
}

