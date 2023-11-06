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

    public partial class PocketMan : Form
    {
        private SystemSound audioRdBtn = SystemSounds.Beep; // radio button selection

        public PocketMan()
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


        private void PocketMan_KeyDown(object sender, KeyEventArgs e)
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

        // Declare the SoundPlayer at the class level
        private SoundPlayer player;

        // select file + play button
        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WAV files (*.wav)|*.wav";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(openFileDialog.FileName);

                player = new SoundPlayer(); // Use the class level instance

                try
                {
                    player.SoundLocation = filePath;
                    player.Load();
                    player.Play();
                    label4.Text = "Currently playing " + fileName;
                }
                catch
                {
                    MessageBox.Show("Are you sure this is a .WAV file?");
                }
          
            }

        }

        // stop button
        private void button2_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
                label4.Text = "No file playing.";
                MessageBox.Show("Stopped by user.");
            }
        }
    }
}