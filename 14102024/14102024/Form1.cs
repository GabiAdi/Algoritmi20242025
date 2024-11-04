using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14102024 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            bool naden = false;
            foreach (String rijec in textBox1.Text.ToLower().Split(' ')) { 
                if(rijec == textBox2.Text) {
                    MessageBox.Show("Je");
                    naden = true;
                    break;
                }
            }
            if (!naden) {
                MessageBox.Show("Nije");
            }

        }
    }
}
