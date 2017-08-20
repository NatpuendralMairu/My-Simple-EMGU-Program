using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;


namespace My_EMGU_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                //Load the Image
                Image<Bgr, Byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);

                //Display the Image
                pictureBox1.Image = My_Image.ToBitmap();
            }
        }
    }
}
