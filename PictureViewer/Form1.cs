﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // shows file browser, after clicking OK upload file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // set image property to null
            pictureBox1.Image = null;
        }

        private void setBackgroundButton_Click(object sender, EventArgs e)
        {
            // shows colours to choose, after take on and click OK change background color of picture box
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void strechtCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // if user check box it should resize img to current windows size
            // if useer uncheck box set img size to normal
            if (strechtCheckbox.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
