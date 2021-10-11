using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoOfPicturebox
{
    public partial class Form1 : Form
    {
        string currentFileName;
        public Form1()
        {
            InitializeComponent();
            currentFileName = "Batman.jpg";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png";
            ofd.FilterIndex = 1;// start with jpg
            ofd.FileName = currentFileName;
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                currentFileName = ofd.FileName;
                imagePictureBox.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
