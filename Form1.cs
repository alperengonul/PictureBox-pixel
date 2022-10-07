using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox_pixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bitmap bmp;
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               pictureBox1.ImageLocation = openFileDialog1.FileName;
               
                bmp = new Bitmap(pictureBox1.ImageLocation);
                
            }
        }
        int xx, yy;
        bool basili = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            basili = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            basili = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            xx = e.X;
            yy = e.Y;
            if ( bmp != null)
            {


                label1.Text = xx.ToString();
                label2.Text = yy.ToString();

                Color renk = bmp.GetPixel(xx, yy);
                label3.Text = renk.Name;

            }
            if (basili)
            {
                Color yenirenk = Color.FromArgb(255, 255, 255);
                bmp.SetPixel(xx, yy, yenirenk);
                pictureBox1.Image = bmp;
            }
          



        }
    }
}