using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Код_Хэмминга
{
    public partial class Kod1Rezim : Form
    {
        public Kod1Rezim()
        {
            InitializeComponent();
            GenerateFirstState();
        }


        /// <summary>
        /// генерация начального состояния регистра
        /// </summary>
        private void GenerateFirstState()
        {

            int[] ArrayFirst = new int[] { Convert.ToInt32(NumberIn1.Text), Convert.ToInt32(NumberIn2.Text), 
                                                                Convert.ToInt32(NumberIn3.Text), Convert.ToInt32(NumberIn4.Text) };
            //Создание объекта для генерации чисел
            Random RandChislo = new Random(DateTime.Now.Millisecond);
            for (int ind = 0; ind < ArrayFirst.Length; ind++)
            {
                //Присвоить случайное число (в диапазоне от 0 до 1)               
                ArrayFirst[ind] = RandChislo.Next(0, 2);
            }
            NumberIn1.Text = ArrayFirst[0].ToString();
            NumberIn2.Text = ArrayFirst[1].ToString();
            NumberIn3.Text = ArrayFirst[2].ToString();
            NumberIn4.Text = ArrayFirst[3].ToString();
        }

        /// <summary>
        /// ввод только 0 и 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="EventArg"></param>
        private void Ogranichenie(object sender, KeyPressEventArgs EventArg)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if ((EventArg.KeyChar <= 47 || EventArg.KeyChar >= 50))
                {
                    EventArg.Handled = true;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CleanerWindow_Click(object sender, EventArgs e)
        {
            CleanforWindow();
            GenerateFirstState();
        }

        private void CleanforWindow()
        {
            NumberIn1.Text = "0";
            NumberIn2.Text = "0";
            NumberIn3.Text = "0";
            NumberIn4.Text = "0";
            ArrayOut1.Text = "0";
            ArrayOut2.Text = "0";
            ArrayOut3.Text = "0";
            ArrayOut4.Text = "0";
            ArrayOut5.Text = "0";
            ArrayOut6.Text = "0";
            ArrayOut7.Text = "0";
            ArrayOut1.Visible = false;
            ArrayOut2.Visible = false;
            ArrayOut3.Visible = false;
            ArrayOut4.Visible = false;
            ArrayOut5.Visible = false;
            ArrayOut6.Visible = false;
            ArrayOut7.Visible = false;
            NumberOut1.Text = "0";
            NumberOut2.Text = "0";
            NumberOut3.Text = "0";
            NumberOut4.Text = "0";
            ProverPriznakIn1.Text = "";
            ProverPriznakIn2.Text = "";
            ProverPriznakIn3.Text = "";
            ProverPriznakOut1.Text = "";
            ProverPriznakOut2.Text = "";
            ProverPriznakOut3.Text = "";
            NumberOut1.Visible = false;
            NumberOut2.Visible = false;
            NumberOut3.Visible = false;
            NumberOut4.Visible = false;
            ProverPriznakIn1.Enabled = true;
            ProverPriznakIn2.Enabled = true;
            ProverPriznakIn3.Enabled = true;
            ProverPriznakOut1.Enabled = true;
            ProverPriznakOut2.Enabled = true;
            ProverPriznakOut3.Enabled = true;
            ProverPriznakIn2.Visible = false;
            ProverPriznakIn3.Visible = false;
            ProverPriznakOut1.Visible = false;
            ProverPriznakOut2.Visible = false;
            ProverPriznakOut3.Visible = false;
            ProverPriznakIn1.Focus();
        }

        private void ProverPriznakIn1_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void ProverPriznakIn2_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void ProverPriznakIn3_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void ProverPriznakOut1_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void ProverPriznakOut2_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void ProverPriznakOut3_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void ProverPriznakIn1_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakIn1.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakIn1.Text);
            if (imod == (Convert.ToInt16(NumberIn1.Text) ^ (Convert.ToInt16(NumberIn2.Text)) ^ (Convert.ToInt16(NumberIn4.Text))))
            {
                ProverPriznakIn2.Visible = true;
                ProverPriznakIn2.Focus();
                ProverPriznakIn1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakIn1.Text = "";
                ProverPriznakIn1.Focus();
            } 
        }

        private void ProverPriznakIn2_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakIn2.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakIn2.Text);
            if (imod == (Convert.ToInt16(NumberIn1.Text) ^ (Convert.ToInt16(NumberIn3.Text)) ^ (Convert.ToInt16(NumberIn4.Text))))
            {
                ProverPriznakIn3.Visible = true;
                ProverPriznakIn3.Focus();
                ProverPriznakIn2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakIn2.Text = "";
                ProverPriznakIn2.Focus();
            }
        }

        /// <summary>
        /// для ошибок
        /// </summary>
        /// <param name="ErrorCount"></param>
        private void WithManyError(int ErrorCount)
        {
            ArrayOut1.Text = ProverPriznakIn1.Text;
            ArrayOut2.Text = ProverPriznakIn2.Text;
            ArrayOut4.Text = ProverPriznakIn3.Text;
            ArrayOut3.Text = NumberIn1.Text;
            ArrayOut5.Text = NumberIn2.Text;
            ArrayOut6.Text = NumberIn3.Text;
            ArrayOut7.Text = NumberIn4.Text;
            int[] ArrayOne = new int[] {Convert.ToInt32(ArrayOut1.Text), Convert.ToInt32(ArrayOut2.Text), 
                               Convert.ToInt32(ArrayOut4.Text), Convert.ToInt32(ArrayOut3.Text), Convert.ToInt32(ArrayOut5.Text), 
                                                               Convert.ToInt32(ArrayOut6.Text), Convert.ToInt32(ArrayOut7.Text)};
            for (int i = 0; i < ErrorCount; i++)
            {
                //выбор рандомного номера элемента массива
                int number = new Random().Next(0, 7);
                //список, собирающий элементы основного массива с ошибками, чтобы они не повторялись
                var someList = new List<int>();
                //bool isContain = someList.Contains(number);
                if (someList.Contains(number))
                {
                    number = 0;
                    number = new Random().Next(0, 7);
                }
                else
                {
                    someList.Add(number);
                }
                int RandErrorSimvol = ArrayOne[number];
                if (RandErrorSimvol == 1)
                {
                    RandErrorSimvol = 0;
                    ArrayOne[number] = RandErrorSimvol;
                    
                }
                else if (RandErrorSimvol == 0)
                {
                    RandErrorSimvol = 1;
                    ArrayOne[number] = RandErrorSimvol;
                    
                }
                ArrayOut1.Text = ArrayOne[0].ToString();
                ArrayOut2.Text = ArrayOne[1].ToString();
                ArrayOut4.Text = ArrayOne[2].ToString();
                ArrayOut3.Text = ArrayOne[3].ToString();
                ArrayOut5.Text = ArrayOne[4].ToString();
                ArrayOut6.Text = ArrayOne[5].ToString();
                ArrayOut7.Text = ArrayOne[6].ToString();
                number = 0;
            }
        }

        private void ProverPriznakIn3_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakIn3.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakIn3.Text);
            if (imod == (Convert.ToInt16(NumberIn2.Text) ^ (Convert.ToInt16(NumberIn3.Text)) ^ (Convert.ToInt16(NumberIn4.Text))))
            {
                ProverPriznakIn3.Enabled = false;
                ArrayOut1.Visible = true;
                ArrayOut2.Visible = true;
                ArrayOut3.Visible = true;
                ArrayOut4.Visible = true;
                ArrayOut5.Visible = true;
                ArrayOut6.Visible = true;
                ArrayOut7.Visible = true;
                ArrayOut1.Text = ProverPriznakIn1.Text;
                ArrayOut2.Text = ProverPriznakIn2.Text;
                ArrayOut4.Text = ProverPriznakIn3.Text;
                ArrayOut3.Text = NumberIn1.Text;
                ArrayOut5.Text = NumberIn2.Text;
                ArrayOut6.Text = NumberIn3.Text;
                ArrayOut7.Text = NumberIn4.Text;
                ProverPriznakOut1.Visible = true;
                ProverPriznakOut1.Focus();
                WithManyError(1);
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakIn3.Text = "";
                ProverPriznakIn3.Focus();
            }
        }

        private void ProverPriznakOut1_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakOut1.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakOut1.Text);
            if (imod == (Convert.ToInt16(ArrayOut1.Text) ^ Convert.ToInt16(ArrayOut3.Text) ^ Convert.ToInt16(ArrayOut5.Text) ^ Convert.ToInt16(ArrayOut7.Text)))
            {
                ProverPriznakOut1.Enabled = false;
                ProverPriznakOut2.Visible = true;
                ProverPriznakOut2.Focus();
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakOut1.Text = "";
                ProverPriznakOut1.Focus();
            }
        }

        private void ProverPriznakOut2_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakOut2.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakOut2.Text);
            if (imod == (Convert.ToInt16(ArrayOut2.Text) ^ Convert.ToInt16(ArrayOut3.Text) ^ Convert.ToInt16(ArrayOut6.Text) ^ Convert.ToInt16(ArrayOut7.Text)))
            {
                ProverPriznakOut2.Enabled = false;
                ProverPriznakOut3.Visible = true;
                ProverPriznakOut3.Focus();
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakOut2.Text = "";
                ProverPriznakOut2.Focus();
            }
        }

        private void ProverPriznakOut3_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakOut3.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakOut3.Text);
            if (imod == (Convert.ToInt16(ArrayOut4.Text) ^ Convert.ToInt16(ArrayOut5.Text) ^ Convert.ToInt16(ArrayOut6.Text) ^ Convert.ToInt16(ArrayOut7.Text)))
            {
                ProverPriznakOut3.Enabled = false;
                buttonForCreate.Visible = true;
                buttonForCreate.Focus();
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakOut3.Text = "";
                ProverPriznakOut3.Focus();
            }
        }

        private void buttonForCreate_Click(object sender, EventArgs e)
        {
            NumberOut1.Text = NumberIn1.Text;
            NumberOut2.Text = NumberIn2.Text;
            NumberOut3.Text = NumberIn3.Text;
            NumberOut4.Text = NumberIn4.Text;
            NumberOut1.Visible = true;
            NumberOut2.Visible = true;
            NumberOut3.Visible = true;
            NumberOut4.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
