using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace _28102024 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            imagesCb.Add("https://picsum.photos/id/100/100/900");
            imagesCb.Add("https://picsum.photos/id/101/100/100");
            imagesCb.Add("https://picsum.photos/id/102/200/200");
            imagesCb.Add("https://picsum.photos/id/103/300/400");
            imagesCb.Add("https://picsum.photos/id/104/400/600");
            imagesCb.Add("https://picsum.photos/id/109/400/400");
            imagesCb.Add("https://picsum.photos/id/106/600/100");
            imagesCb.Add("https://picsum.photos/id/107/700/700");
            imagesCb.Add("https://picsum.photos/id/108/800/900");
            imagesLb = new ArrayList(imagesCb);
            for (int i = 0; i < imagesLb.Count; i++) {
                lb_choice.Items.Add("Image " + i);
            }
            for (int i = 0; i < imagesCb.Count; i++) {
                cb_choice.Items.Add("Image " + i);
            }
        }

        ArrayList imagesCb = new ArrayList();
        ArrayList imagesLb = new ArrayList();

        private void promjeniSlike() {
            if (rb_img1normal.Checked) {
                img1.SizeMode = PictureBoxSizeMode.Normal;
            }
            else if (rb_img1stretch.Checked) {
                img1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (rb_img1center.Checked) {
                img1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (rb_img1auto.Checked) {
                img1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (rb_img1zoom.Checked) {
                img1.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (rb_img2normal.Checked) {
                img2.SizeMode = PictureBoxSizeMode.Normal;
            }
            else if (rb_img2stretch.Checked) {
                img2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (rb_img2center.Checked) {
                img2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (rb_img2auto.Checked) {
                img2.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (rb_img2zoom.Checked) {
                img2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void cb_choice_SelectedIndexChanged(object sender, EventArgs e) { // Combo box (img 1)
            img1.ImageLocation = imagesCb[cb_choice.SelectedIndex].ToString();
        }

        private void lb_choice_SelectedIndexChanged(object sender, EventArgs e) { // List box (img 2)
            img2.ImageLocation = imagesLb[lb_choice.SelectedIndex].ToString();
        }

        private void rb_img1normal_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img1stretch_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img1auto_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img1center_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img1zoom_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img2normal_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img2stretch_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img2auto_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img2center_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void rb_img2zoom_CheckedChanged(object sender, EventArgs e) {
            promjeniSlike();
        }

        private void bt_addImg_Click(object sender, EventArgs e) {
            imagesLb.Add(tb_image.Text);
            imagesCb.Add(tb_image.Text);
            cb_choice.Items.Add(tb_imgName.Text);
            lb_choice.Items.Add(tb_imgName.Text);
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Gabriel Murk");
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e) {
            var tsItem = (ToolStripMenuItem)sender;
            var cms = (ContextMenuStrip)tsItem.Owner;
            if (cms.SourceControl is ListBox) {
                lb_choice.Items.Clear();
                imagesLb.Clear();
            }
            if (cms.SourceControl is ComboBox) {
                cb_choice.Items.Clear();
                imagesCb.Clear();
            }

        }
    }
}
