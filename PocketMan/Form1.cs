using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace PocketMan
{

    public partial class Form1 : Form
    {
        private SystemSound audioRdBtn = SystemSounds.Beep; // radio button selection
        private DirectorySelectorForm selectedDirectory; // selected file for play
        private SoundPlayer player = new SoundPlayer(); // class-level sound player instance so it can be accessed from all methods

        public Form1()
        {
            InitializeComponent();
            mainWindowTab.SelectedIndexChanged += mainWindowTab_SelectedIndexChanged; // check tab change event
        }

        private void mainWindowTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = mainWindowTab.TabPages[mainWindowTab.SelectedIndex].Text; // set form title to active tab
        }

        // check radio button selection for corresponding SystemSound member
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            audioRdBtn = SystemSounds.Beep;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            audioRdBtn = SystemSounds.Asterisk;
        }

        // play audio from selection on button click
        private void button1_Click(object sender, EventArgs e)
        {
            audioRdBtn.Play();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        // select file + play button
        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(openFileDialog.FileName);
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = filePath;
                player.Load();
                player.Play();
                label4.Text = "Currently playing " + fileName;
            }

        }

        // stop button
        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            MessageBox.Show("Stopped by user.");
        }


    }
}