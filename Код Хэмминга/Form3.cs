using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Код_Хэмминга
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HelperForStatisticcs Helper = new HelperForStatisticcs();
            Helper.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }


        /// <summary>
        /// передать 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            string source = textBox1.Text;
            int number = new Random().Next(0, source.Length);
            MessageBox.Show(String.Format("произошла ошибка в {0} символе", number), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            char SimvolOshibki = source[number];
            string kovichka1 = "(";
            string kovichka2 = ")";
            MessageBox.Show(String.Format("Символ {0} {1} {2} передан с ошибкой", kovichka1, SimvolOshibki, kovichka2), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //bukva - выбранный символ, именно символ
                if (number+2 < source.Length) { 
                char zamenaBukvi = source[number + 2];
                string bukva = Convert.ToString(zamenaBukvi);
                MessageBox.Show(String.Format("Символу {0} присвоено значение {1} {2} {3}", number, kovichka1, source[number + 2], kovichka2), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                source = source.Insert(number, bukva);
                //удалить все, что после sourse[number]
                source = source.Remove(number+1, 1);
                SolidBrush drawBrush = new SolidBrush(Color.Aqua);
                Font drawFont = new Font("Arial", 16);
                } else return;
                textBox2.Text = source;
            }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Focus();
        }
    }
    }

