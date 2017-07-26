using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace compare_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile1_Click(object sender, EventArgs e)
        {
            dlgSelectFile.FileName = txtFile1.Text;
            if (dlgSelectFile.ShowDialog() == DialogResult.OK)
            {
                txtFile1.Text = dlgSelectFile.FileName;
                lblResult.Text = "";
                try
                {
                    Bitmap bm = new Bitmap(txtFile1.Text);
                    picImage1.Image = (Bitmap)bm.Clone();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnGo.Enabled = (
                    (picImage1.Image != null) &&
                    (picImage2.Image != null));
            }
        }

        private void btnFile2_Click(object sender, EventArgs e)
        {
            dlgSelectFile.FileName = txtFile2.Text;
            if (dlgSelectFile.ShowDialog() == DialogResult.OK)
            {
                txtFile2.Text = dlgSelectFile.FileName;
                lblResult.Text = "";
                try
                {
                    Bitmap bm = new Bitmap(txtFile2.Text);
                    picImage2.Image = (Bitmap)bm.Clone();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnGo.Enabled = (
                    (picImage1.Image != null) &&
                    (picImage2.Image != null));
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // Load the images.
            Bitmap bm1 = (Bitmap)picImage1.Image;
            Bitmap bm2 = (Bitmap)picImage2.Image;

            // Make a difference image.
            int wid = Math.Min(bm1.Width, bm2.Width);
            int hgt = Math.Min(bm1.Height, bm2.Height);
            Bitmap bm3 = new Bitmap(wid, hgt);

            // Create the difference image.
            bool are_identical = true;
            Color eq_color = Color.White;
            Color ne_color = Color.Red;
            for (int x = 0; x < wid; x++)
            {
                for (int y = 0; y < hgt; y++)
                {
                    if (bm1.GetPixel(x, y).Equals(bm2.GetPixel(x, y)))
                        bm3.SetPixel(x, y, eq_color);
                    else
                    {
                        bm3.SetPixel(x, y, ne_color);
                        are_identical = false;
                    }
                }
            }

            // Display the result.
            picResult.Image = bm3;

            this.Cursor = Cursors.Default;
            if ((bm1.Width != bm2.Width) || (bm1.Height != bm2.Height)) are_identical = false;
            if (are_identical)
                lblResult.Text = "The images are identical";
            else
                lblResult.Text = "The images are different";
        }
    }
}
