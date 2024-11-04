using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21102024 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void bt_izracunaj_Click(object sender, EventArgs e) {
            try {
                if (rb_zbrajanje.Checked) {
                    tb_rezultat.Text = (float.Parse(tb_broj1.Text) + float.Parse(tb_broj2.Text)).ToString();

                }
                else if (rb_oduzimanje.Checked) {
                    tb_rezultat.Text = (float.Parse(tb_broj1.Text) - float.Parse(tb_broj2.Text)).ToString();
                }
                if (rb_mnozenje.Checked) {
                    tb_rezultat.Text = (float.Parse(tb_broj1.Text) * float.Parse(tb_broj2.Text)).ToString();
                }
                if (rb_dijeljenje.Checked) {
                    if (float.Parse(tb_broj2.Text) == 0f) {
                        tb_rezultat.Text = "Error";
                    }
                    else {
                        tb_rezultat.Text = (float.Parse(tb_broj1.Text) / float.Parse(tb_broj2.Text)).ToString();
                    }

                }
            }
            catch {
                tb_rezultat.Text = "Error";
            }
         
            foreach(Control c in Controls) {
               if (c.GetType() == typeof(RadioButton)) {
                   c.Visible = false;
               }
            }
        }
    }
}
