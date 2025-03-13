using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program5_9
{
    public partial class Form1 : Form
    {
        private Random Rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Rand.Next(1, 7);
            int n2 = Rand.Next(1, 7);

            showPictureBox1(n1, pictureBox1);
            showPictureBox2(n2, pictureBox2);

            switch (n1)
            {
                case 1:
                    pictureBox1.Image = Program5_9.Properties.Resources.Die1;
                    break;
                case 2:
                    pictureBox1.Image = Program5_9.Properties.Resources.Die2;
                    break;
                case 3:
                    pictureBox1.Image = Program5_9.Properties.Resources.Die3;
                    break;
                case 4:
                    pictureBox1.Image = Program5_9.Properties.Resources.Die4;
                    break;
                case 5:
                    pictureBox1.Image = Program5_9.Properties.Resources.Die5;
                    break;
                case 6:
                    pictureBox1.Image = Program5_9.Properties.Resources.Die6;
                    break;
            }

            switch (n2)
            {
                case 1:
                    pictureBox2.Image = Program5_9.Properties.Resources.Die1;
                    break;
                case 2:
                    pictureBox2.Image = Program5_9.Properties.Resources.Die2;
                    break;
                case 3:
                    pictureBox2.Image = Program5_9.Properties.Resources.Die3;
                    break;
                case 4:
                    pictureBox2.Image = Program5_9.Properties.Resources.Die4;
                    break;
                case 5:
                    pictureBox2.Image = Program5_9.Properties.Resources.Die5;
                    break;
                case 6:
                    pictureBox2.Image = Program5_9.Properties.Resources.Die6;
                    break;
            }
     
        }

        private void showPictureBox1(int n1, PictureBox pic)
        {
            switch (n1)
            {
                case 1:
                    pic.Image = Program5_9.Properties.Resources.Die1;
                    break;
                case 2:
                    pic.Image = Program5_9.Properties.Resources.Die2;
                    break;
                case 3:
                    pic.Image = Program5_9.Properties.Resources.Die3;
                    break;
                case 4:
                    pic.Image = Program5_9.Properties.Resources.Die4;
                    break;
                case 5:
                    pic.Image = Program5_9.Properties.Resources.Die5;
                    break;
                case 6:
                    pic.Image = Program5_9.Properties.Resources.Die6;
                    break;
            }
        }
        private void showPictureBox2(int n2, PictureBox pic)
        {
            switch (n2)
            {
                case 1:
                    pic.Image = Program5_9.Properties.Resources.Die1;
                    break;
                case 2:
                    pic.Image = Program5_9.Properties.Resources.Die2;
                    break;
                case 3:
                    pic.Image = Program5_9.Properties.Resources.Die3;
                    break;
                case 4:
                    pic.Image = Program5_9.Properties.Resources.Die4;
                    break;
                case 5:
                    pic.Image = Program5_9.Properties.Resources.Die5;
                    break;
                case 6:
                    pic.Image = Program5_9.Properties.Resources.Die6;
                    break;
            }
        }
    }
}
        
          


