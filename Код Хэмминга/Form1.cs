using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Код_Хэмминга
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) {
                Kod1Rezim kod = new Kod1Rezim();
                kod.ShowDialog();
            }
            else if (radioButton3.Checked == true) {
                KodModif kod = new KodModif();
                kod.ShowDialog();
            }
            else if (radioButton1.Checked == true) {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (radioButton2.Checked == true) {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
