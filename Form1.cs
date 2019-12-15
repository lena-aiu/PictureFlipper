﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureFlipper
{
    public partial class Form1 : Form
    {
        Button button1;
        Bitmap image1;
        PictureBox pictureBox1;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Pictures' flip";
            this.Size = new Size(302, 240);
            button1 = new Button();
            button1.Text = "Picture's flip";
            button1.Location = new Point(100, 150);
            button1.Size = new Size(70, 40);
            button1.Click += new System.EventHandler(button1_Click);
            this.Controls.Add(button1);

            pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ClientSize = new Size(300, 196);

            image1 = new Bitmap(@"../../images/ice_womens.jpg");
            pictureBox1.Image = (Image)image1;

            this.Controls.Add(pictureBox1);


        }


        static void Main()
        {
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void button1_Click(object sender, EventArgs e)

        {
            image1.RotateFlip(RotateFlipType.RotateNoneFlipX);

            pictureBox1.Image = (Image)image1;

            this.Text = "Picture after flip!";
        }



    }
}
