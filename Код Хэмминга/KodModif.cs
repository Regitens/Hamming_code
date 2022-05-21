using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections.Generic;

namespace Код_Хэмминга
{
    public partial class KodModif : Form
    {
        //int ErrorCount=new int();

        public KodModif()
        {
            InitializeComponent();
            GenerateFirstState();
        }


        /// <summary>
        /// генерация начального состояния регистра
        /// </summary>
        private void GenerateFirstState() {
            
            int[] ArrayFirst = new int[] { Convert.ToInt32(NumberIn1.Text), Convert.ToInt32(NumberIn2.Text), 
                                                                Convert.ToInt32(NumberIn3.Text), Convert.ToInt32(NumberIn4.Text) };
            //Создание объекта для генерации чисел
            Random RandChislo=new Random(DateTime.Now.Millisecond);
            for (int ind=0; ind < ArrayFirst.Length; ind++) {
                //Присвоить случайное число (в диапазоне от 0 до 1)               
                ArrayFirst[ind] = RandChislo.Next(0,2);
            } 
            NumberIn1.Text = ArrayFirst[0].ToString();
            NumberIn2.Text = ArrayFirst[1].ToString();
            NumberIn3.Text = ArrayFirst[2].ToString();
            NumberIn4.Text = ArrayFirst[3].ToString();
        } 

        private void label14_Click(object sender, EventArgs e)
        {

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


        /// <summary>
        /// ввод только цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="EventArg"></param>
        private void OgranichenieNaCifri(object sender, KeyPressEventArgs EventArg)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if ((EventArg.KeyChar <= 47 || EventArg.KeyChar >= 56))
                {
                    EventArg.Handled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakIn1.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakIn1.Text);
            if (imod == (Convert.ToInt16(NumberIn1.Text) ^ (Convert.ToInt16(NumberIn2.Text)) ^ (Convert.ToInt16(NumberIn4.Text))))
            {
                ProverPriznakIn2.Visible=true;
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

        private void button1_Click(object sender, EventArgs e)
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
            ArrayIn1.Text = "0";
            ArrayIn2.Text = "0";
            ArrayIn4.Text = "0";
            ArrayIn3.Text = "0";
            ArrayIn5.Text = "0";
            ArrayIn6.Text = "0";
            ArrayIn7.Text = "0";
            ArrayIn1.Visible = false;
            ArrayIn2.Visible = false;
            ArrayIn4.Visible = false;
            ArrayIn3.Visible = false;
            ArrayIn5.Visible = false;
            ArrayIn6.Visible = false;
            ArrayIn7.Visible = false;
            ArrayOut1.Text = "0";
            ArrayOut2.Text = "0";
            ArrayOut4.Text = "0";
            ArrayOut3.Text = "0";
            ArrayOut5.Text = "0";
            ArrayOut6.Text = "0";
            ArrayOut7.Text = "0";
            ArrayOut1.Visible = false;
            ArrayOut2.Visible = false;
            ArrayOut4.Visible = false;
            ArrayOut3.Visible = false;
            ArrayOut5.Visible = false;
            ArrayOut6.Visible = false;
            ArrayOut7.Visible = false;
            NumberOut1.Text = "0";
            NumberOut2.Text = "0";
            NumberOut3.Text = "0";
            NumberOut4.Text = "0";
            PriznakNalichiyaOshibki.Text = "0";
            PriznakOshibki1.Text = "0";
            PriznakOshibki2.Text = "0";
            PriznakOshibki3.Text = "0";
            ProverPriznakIn1.Text = "";
            ProverPriznakIn2.Text = "";
            ProverPriznakIn3.Text = "";
            PriznakIn.Text = "";
            PriznakOut.Text = "";
            PriznakSravnenie.Text = "";
            ProverPriznakOut1.Text = "";
            ProverPriznakOut2.Text = "";
            ProverPriznakOut3.Text = "";
            NumberOut1.Visible = false;
            NumberOut2.Visible = false;
            NumberOut3.Visible = false;
            NumberOut4.Visible = false;
            PriznakNalichiyaOshibki.Visible = false;
            PriznakOshibki1.Visible = false;
            PriznakOshibki2.Visible = false;
            PriznakOshibki3.Visible = false;
            panel1.Visible = false;
            ProverPriznakIn1.Enabled = true;
            ProverPriznakIn2.Enabled = true;
            ProverPriznakIn3.Enabled = true;
            PriznakIn.Enabled = true;
            PriznakOut.Enabled = true;
            PriznakSravnenie.Enabled = true;
            ProverPriznakOut1.Enabled = true;
            ProverPriznakOut2.Enabled = true;
            ProverPriznakOut3.Enabled = true;
            ProverPriznakIn2.Visible = false;
            ProverPriznakIn3.Visible = false;
            PriznakIn.Visible = false;
            PriznakOut.Visible = false;
            PriznakSravnenie.Visible = false;
            ProverPriznakOut1.Visible = false;
            ProverPriznakOut2.Visible = false;
            ProverPriznakOut3.Visible = false;
            ProverPriznakIn1.Focus();
            HelperText.Visible = false;
            razryadOshibki.Visible = false;
            GroupForTest.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakIn3.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakIn3.Text);
            if (imod == (Convert.ToInt16(NumberIn2.Text) ^ (Convert.ToInt16(NumberIn3.Text)) ^ (Convert.ToInt16(NumberIn4.Text))))
            {
                ProverPriznakIn3.Enabled = false;
                PriznakIn.Visible = true;
                PriznakIn.Focus();
                ArrayIn1.Visible = true;
                ArrayIn2.Visible = true;
                ArrayIn4.Visible = true;
                ArrayIn3.Visible = true;
                ArrayIn5.Visible = true;
                ArrayIn6.Visible = true;
                ArrayIn7.Visible = true;
                ArrayIn1.Text = ProverPriznakIn1.Text;
                ArrayIn2.Text = ProverPriznakIn2.Text;
                ArrayIn4.Text = ProverPriznakIn3.Text;
                ArrayIn3.Text = NumberIn1.Text;
                ArrayIn5.Text = NumberIn2.Text;
                ArrayIn6.Text = NumberIn3.Text;
                ArrayIn7.Text = NumberIn4.Text;
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakIn3.Text = "";
                ProverPriznakIn3.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (PriznakIn.Text == "") return;
            int imod = Convert.ToInt16(PriznakIn.Text);
            if (imod == (Convert.ToInt16(NumberIn1.Text) ^ Convert.ToInt16(NumberIn2.Text) ^ Convert.ToInt16(NumberIn3.Text) ^ Convert.ToInt16(NumberIn4.Text) ^ Convert.ToInt16(ProverPriznakIn1.Text) ^ Convert.ToInt16(ProverPriznakIn2.Text)^Convert.ToInt16(ProverPriznakIn3.Text)))
            {
                PriznakIn.Enabled = false;
                buttonForErrorGenerate.Focus();
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriznakIn.Text = "";
                PriznakIn.Focus();
            }
        }

        /// <summary>
        /// для ошибок
        /// </summary>
        /// <param name="ErrorCount"></param>
        private void WithManyError(int ErrorCount)
        {
            ArrayOut1.Text = ArrayIn1.Text;
            ArrayOut2.Text = ArrayIn2.Text;
            ArrayOut4.Text = ArrayIn4.Text;
            ArrayOut3.Text = ArrayIn3.Text;
            ArrayOut5.Text = ArrayIn5.Text;
            ArrayOut6.Text = ArrayIn6.Text;
            ArrayOut7.Text = ArrayIn7.Text;
            int[] ArrayOne = new int[] {Convert.ToInt32(ArrayOut1.Text), Convert.ToInt32(ArrayOut2.Text), 
                               Convert.ToInt32(ArrayOut4.Text), Convert.ToInt32(ArrayOut3.Text), Convert.ToInt32(ArrayOut5.Text), 
                                                               Convert.ToInt32(ArrayOut6.Text), Convert.ToInt32(ArrayOut7.Text)};
            var someList = CreateErrorIndexList(ErrorCount, ArrayOne.Length);
           
            foreach (var randomIndex in someList)
            {
                ArrayOne[randomIndex] = (ArrayOne[randomIndex] + 1) % 2;
            }
            ArrayOut1.Text = ArrayOne[0].ToString();
            ArrayOut2.Text = ArrayOne[1].ToString();
            ArrayOut4.Text = ArrayOne[2].ToString();
            ArrayOut3.Text = ArrayOne[3].ToString();
            ArrayOut5.Text = ArrayOne[4].ToString();
            ArrayOut6.Text = ArrayOne[5].ToString();
            ArrayOut7.Text = ArrayOne[6].ToString();
        }
        //generate list with unique random numbers from 0 to maxIndex
        //errorCount - length of generated array
        private static List<int> CreateErrorIndexList(int errorCount, int maxIndex)
        {
            List<int> someList = new List<int>();

            while (someList.Count < errorCount)
            {
                var number = new Random().Next(0, maxIndex);
                if (someList.Contains(number))
                {
                    continue;
                }
                someList.Add(number);
            }
            return someList;
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (PriznakOut.Text == "") return;
            int imod = Convert.ToInt16(PriznakOut.Text);
            if (imod == (Convert.ToInt16(ArrayOut1.Text) ^ Convert.ToInt16(ArrayOut2.Text) ^ Convert.ToInt16(ArrayOut4.Text) ^ Convert.ToInt16(ArrayOut3.Text) ^ Convert.ToInt16(ArrayOut5.Text) ^ Convert.ToInt16(ArrayOut6.Text) ^ Convert.ToInt16(ArrayOut7.Text)))
            {
                PriznakOut.Enabled = false;
                PriznakSravnenie.Visible = true;
                PriznakSravnenie.Focus();
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriznakOut.Text = "";
                PriznakOut.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (PriznakSravnenie.Text == "") return;
            int imod = Convert.ToInt16(PriznakSravnenie.Text);
            if (imod == (Convert.ToInt16(PriznakIn.Text) ^ Convert.ToInt16(PriznakOut.Text)))
            {
                PriznakSravnenie.Enabled = false;
                ProverPriznakOut1.Visible = true;
                ProverPriznakOut1.Focus();
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriznakSravnenie.Text = "";
                PriznakSravnenie.Focus();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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

        private void textBox8_TextChanged(object sender, EventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (ProverPriznakOut3.Text == "") return;
            int imod = Convert.ToInt16(ProverPriznakOut3.Text);
            if (imod == (Convert.ToInt16(ArrayOut4.Text) ^ Convert.ToInt16(ArrayOut5.Text) ^ Convert.ToInt16(ArrayOut6.Text) ^ Convert.ToInt16(ArrayOut7.Text)))
            {
                ProverPriznakOut3.Enabled = false;
                PriznakNalichiyaOshibki.Text=PriznakSravnenie.Text;
                PriznakOshibki1.Text = ProverPriznakOut1.Text;
                PriznakOshibki2.Text = ProverPriznakOut2.Text;
                PriznakOshibki3.Text = ProverPriznakOut3.Text;
                PriznakNalichiyaOshibki.Visible = true;
                PriznakOshibki1.Visible = true;
                PriznakOshibki2.Visible = true;
                PriznakOshibki3.Visible = true;
                HelperText.Visible = true;
                razryadOshibki.Visible = true;

                /*ArrayIn1.Visible = false;
                ArrayIn2.Visible = false;
                ArrayIn4.Visible = false;
                ArrayIn3.Visible = false;
                ArrayIn5.Visible = false;
                ArrayIn6.Visible = false;
                ArrayIn7.Visible = false;

                ArrayOut1.Visible = false;
                ArrayOut2.Visible = false;
                ArrayOut4.Visible = false;
                ArrayOut3.Visible = false;
                ArrayOut5.Visible = false;
                ArrayOut6.Visible = false;
                ArrayOut7.Visible = false;*/

                string somePriznak = ProverPriznakOut3.Text + ProverPriznakOut2.Text + ProverPriznakOut1.Text;
                razryadOshibki.Text = Convert.ToString(Convert.ToInt32(somePriznak,2), 10);
                
                NumberOut1.Visible = true;
                NumberOut2.Visible = true;
                NumberOut3.Visible = true;
                NumberOut4.Visible = true;
                CorrectError(razryadOshibki.Text);
                GroupForTest.Visible = true;
            }
            else
            {
                MessageBox.Show("Не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProverPriznakOut3.Text = "";
                ProverPriznakOut3.Focus();
            }
            
        }


        private void CorrectError(string razryadOshibki)
        {
            int NumberForСorrection = Convert.ToInt32(razryadOshibki);
            int[] ArrayOut = new int[]
            {
                Convert.ToInt32(ArrayOut1.Text), Convert.ToInt32(ArrayOut2.Text),
                Convert.ToInt32(ArrayOut3.Text), Convert.ToInt32(ArrayOut4.Text),
                Convert.ToInt32(ArrayOut5.Text), Convert.ToInt32(ArrayOut6.Text),
                Convert.ToInt32(ArrayOut7.Text)
            };
            NumberForСorrection = NumberForСorrection - 1;
            ArrayOut[NumberForСorrection] = (ArrayOut[NumberForСorrection] + 1) % 2;
            ArrayOut1.Text=ArrayOut[0].ToString();
            ArrayOut2.Text=ArrayOut[1].ToString();
            ArrayOut3.Text=ArrayOut[2].ToString();
            ArrayOut4.Text=ArrayOut[3].ToString();
            ArrayOut5.Text=ArrayOut[4].ToString();
            ArrayOut6.Text=ArrayOut[5].ToString();
            ArrayOut7.Text=ArrayOut[6].ToString();
            
            
            NumberOut1.Text = ArrayOut3.Text;
            NumberOut2.Text = ArrayOut5.Text;
            NumberOut3.Text = ArrayOut6.Text;
            NumberOut4.Text = ArrayOut7.Text;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (For1Error.Checked == true)
            {
                WithManyError(1);
            }
            else if (For2Error.Checked == true)
            {
                WithManyError(2);
            }
            else if (For3Error.Checked == true)
            {
                WithManyError(3);
            }
            else if (For4Error.Checked == true)
            {
                WithManyError(4);
            }
            PriznakOut.Visible = true;
            ArrayOut1.Visible = true;
            ArrayOut2.Visible = true;
            ArrayOut4.Visible = true;
            ArrayOut3.Visible = true;
            ArrayOut5.Visible = true;
            ArrayOut6.Visible = true;
            ArrayOut7.Visible = true;
            PriznakOut.Focus();
            panel1.Visible = false;
        }

/// <summary>
/// определение места ошибки и исправление ошибочного разряда
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void razryadOshibki_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            OgranichenieNaCifri(sender, EventArg);
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            HelperForModif Helper = new HelperForModif();
            Helper.ShowDialog();
        }


        private void ButtonTestVariant_Click(object sender, EventArgs e)
        {
            if (For1Error.Checked || For3Error.Checked) {
                if (NechetVariant.Checked == true) {
                    MessageBox.Show("Верно.Дополнительный разряд равен 1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Не верно. Обратите внимание на дополнительный разряд", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (For2Error.Checked || For4Error.Checked) { 
                if (ChetVariant.Checked == true) {
                    MessageBox.Show("Верно. Дополнительный разряд равен 0", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Не верно. Обратите внимание на дополнительный разряд", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CleanerWindow.Focus();
        }

        private void razryadOshibki_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
