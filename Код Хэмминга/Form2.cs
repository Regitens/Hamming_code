using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct ASCII {
   public char c;
   public byte cod;
}



namespace Код_Хэмминга
{
    public partial class Form2 : Form
    {
        List<ASCII> Table;
        public Form2()
        {
            InitializeComponent();
            InitializeTable();
            
        }


        void InitializeTable()
        {
            Table = new List<ASCII>();
            string ss = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            byte t=192;
            foreach (char c in ss) 
            {
                Table.Add(new ASCII() { c = c, cod = t });
                t++;
            }

            ss = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            foreach (char c in ss)
            {
                Table.Add(new ASCII() { c = c, cod = t });
                t++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

 

        private void button2_Click_1(object sender, EventArgs e)
        {
            char letter1 = textBox1.Text[0];
            byte y = Table.Where(t => t.c == letter1).Select(t => t.cod).SingleOrDefault();
            string ss = Convert.ToString(y, 2).ToString();
            label1.Text = ss[0].ToString();
            label2.Text = ss[1].ToString();
            label3.Text = ss[2].ToString();
            label4.Text = ss[3].ToString();
            label5.Text = ss[4].ToString();
            label6.Text = ss[5].ToString();
            label7.Text = ss[6].ToString();
            label8.Text = ss[7].ToString();
            ArrayIn3.Text = ss[0].ToString();
            ArrayIn5.Text = ss[1].ToString();
            ArrayIn6.Text = ss[2].ToString();
            ArrayIn7.Text = ss[3].ToString();
            ArrayIn9.Text = ss[4].ToString();
            ArrayIn10.Text = ss[5].ToString();
            ArrayIn11.Text = ss[6].ToString();
            ArrayIn12.Text = ss[7].ToString();
            ArrayIn1.Enabled = true;
            ArrayIn1.Focus();
        }


        /// <summary>
        /// очистить поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CleanforWord();
            CleanForTextWord();
        }
        
        private void CleanForTextWord()
        {
            Word10.Clear();
            Word9.Clear();
            Word8.Clear();
            Word7.Clear();
            Word6.Clear();
            Word5.Clear();
            Word4.Clear();
            Word3.Clear();
            Word2.Clear();
            Word1.Clear();
        }

        /// <summary>
        /// очистка для начала ввода новой буквы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CleanforWord() { 
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            ArrayIn3.Text = "0";
            ArrayIn5.Text = "0";
            ArrayIn6.Text = "0";
            ArrayIn7.Text = "0";
            ArrayIn9.Text = "0";
            ArrayIn10.Text = "0";
            ArrayIn11.Text = "0";
            ArrayIn12.Text = "0";
            ArrayOut1.Text = "0";
            ArrayOut2.Text = "0";
            ArrayOut3.Text = "0";
            ArrayOut4.Text = "0";
            ArrayOut7.Text = "0";
            ArrayOut6.Text = "0";
            ArrayOut5.Text = "0";
            ArrayOut8.Text = "0";
            ArrayOut12.Text = "0";
            ArrayOut11.Text = "0";
            ArrayOut10.Text = "0";
            ArrayOut9.Text = "0";
            label29.Text = "0";
            label30.Text = "0";
            label31.Text = "0";
            label32.Text = "0";
            label33.Text = "0";
            label34.Text = "0";
            label35.Text = "0";
            label36.Text = "0";
            ArrayIn1.Enabled = false;
            ArrayIn2.Enabled = false;
            ArrayIn4.Enabled = false;
            ArrayIn8.Enabled = false;
            button2.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            textBox1.Text = "";
            ArrayIn1.Text = "";
            ArrayIn2.Text = "";
            ArrayIn4.Text = "";
            ArrayIn8.Text = "";
            textBox1.Enabled = true;
            textBox1.Focus();
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ArrayIn1.Enabled = true;
            button2.Enabled = true;
            button2.Focus();
            textBox1.Enabled = false;
        }


        /// <summary>
        /// изменения для текста 1 разряда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (ArrayIn1.Text=="") return;
            int imod = Convert.ToInt16(ArrayIn1.Text);
            if (imod == (Convert.ToInt16(ArrayIn3.Text) ^ (Convert.ToInt16(ArrayIn5.Text)) ^ (Convert.ToInt16(ArrayIn7.Text)) ^ (Convert.ToInt16(ArrayIn9.Text)) ^ (Convert.ToInt16(ArrayIn11.Text))))
            {
                ArrayIn2.Enabled = true;
                ArrayIn2.Focus();
                button2.Visible = false;
                ArrayIn1.Enabled = false;
            }
            else {
                ArrayIn1.Text = "";
                ArrayIn1.Focus();
                 } 
        }

        /// <summary>
        /// изменения для текста 2 разряда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (ArrayIn2.Text == "") return;
            int imod = Convert.ToInt16(ArrayIn2.Text);
            if (imod == (Convert.ToInt16(ArrayIn3.Text) ^ (Convert.ToInt16(ArrayIn6.Text)) ^ (Convert.ToInt16(ArrayIn7.Text)) ^ (Convert.ToInt16(ArrayIn10.Text)) ^ (Convert.ToInt16(ArrayIn11.Text))))
            {
                ArrayIn4.Enabled = true;
                ArrayIn4.Focus();
                ArrayIn2.Enabled = false;
            }
            else
            {
                ArrayIn2.Focus();
                ArrayIn2.Text = "";
            } 
        }


        /// <summary>
        /// изменения для текста 4 разряда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (ArrayIn4.Text == "") return;
            int imod = Convert.ToInt16(ArrayIn4.Text);
            if (imod == (Convert.ToInt16(ArrayIn5.Text) ^ (Convert.ToInt16(ArrayIn6.Text)) ^ (Convert.ToInt16(ArrayIn7.Text)) ^ (Convert.ToInt16(ArrayIn12.Text))))
            {
                ArrayIn8.Enabled = true;
                ArrayIn8.Focus();
                ArrayIn4.Enabled = false;
            }
            else
            {
                ArrayIn4.Focus();
                ArrayIn4.Text = "";
            } 
        }

        /// <summary>
        /// изменения для текста 8 разряда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (ArrayIn8.Text == "") return;
            int imod = Convert.ToInt16(ArrayIn8.Text);
            if (imod == (Convert.ToInt16(ArrayIn9.Text) ^ (Convert.ToInt16(ArrayIn10.Text)) ^ (Convert.ToInt16(ArrayIn11.Text)) ^ (Convert.ToInt16(ArrayIn12.Text))))
            {
                button5.Visible = false;
                ArrayIn8.Enabled = false;
                ArrayIn8.Text = Convert.ToString(imod);
                button4.Visible = true;
                buttonForError.Visible = true;
            }
            else
            {
                ArrayIn8.Focus();
                ArrayIn8.Text = "";
            }
            button4.Focus();
        }

        /// <summary>
        /// очистить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            ArrayOut1.Text = ArrayIn1.Text;
            ArrayOut2.Text = ArrayIn2.Text;
            ArrayOut3.Text = ArrayIn3.Text;
            ArrayOut4.Text = ArrayIn4.Text;
            ArrayOut5.Text = ArrayIn5.Text;
            ArrayOut6.Text = ArrayIn6.Text;
            ArrayOut7.Text = ArrayIn7.Text; 
            ArrayOut8.Text = ArrayIn8.Text;
            ArrayOut9.Text = ArrayIn9.Text;
            ArrayOut10.Text = ArrayIn10.Text;
            ArrayOut11.Text = ArrayIn11.Text;
            ArrayOut12.Text = ArrayIn12.Text;
            button6.Visible = true;
            button6.Focus();
            button4.Visible = false;
            buttonForError.Visible = false;
        }


        string word="";
        /// <summary>
        /// преобразовать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            string s = "";
            char[] ssout = new char[8];
            s += label36.Text;
            s += label35.Text;
            s += label34.Text;
            s += label33.Text;
            s += label32.Text;
            s += label31.Text;
            s += label30.Text;
            s += label29.Text;
            int a = Convert.ToInt16(s, 2);
            char y = Table.Where(t => t.cod == a).Select(t => t.c).SingleOrDefault();
            word = y+word;
            FillWord();
            CleanforWord();
            button2.Enabled = false;
        }

        /// <summary>
        /// сместить на один вверх
        /// </summary>
        void FillWord()
        {
            try
            { Word10.Text = word[0].ToString(); }
            catch { };
            try
            { Word9.Text = word[1].ToString(); }
            catch { };
            try
            { Word8.Text = word[2].ToString(); }
            catch { };
            try
            { Word7.Text = word[3].ToString(); }
            catch { };
            try
            { Word6.Text = word[4].ToString(); }
            catch { };
            try
            { Word5.Text = word[5].ToString(); }
            catch { };
            try
            { Word4.Text = word[6].ToString(); }
            catch { };
            try
            { Word3.Text = word[7].ToString(); }
            catch { };
            try
            { Word2.Text = word[8].ToString(); }
            catch { };
            try
            { Word1.Text = word[9].ToString(); }
            catch { };
        }


        /// <summary>
        /// ввод только 0 и 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="EventArg"></param>
        private void Ogranichenie(object sender, KeyPressEventArgs EventArg) {
            foreach (TextBox tb in this.Controls.OfType<TextBox>()) { 
            if ((EventArg.KeyChar <= 47 || EventArg.KeyChar >= 50))
            {
                EventArg.Handled = true;
            }
            }
        }

        /// <summary>
        /// обработка исключений на ввод
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs EventArg)
        {
            Ogranichenie(sender, EventArg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label36.Text = ArrayOut3.Text;
            label35.Text = ArrayOut5.Text;
            label34.Text = ArrayOut6.Text;
            label33.Text = ArrayOut7.Text;
            label32.Text = ArrayOut9.Text;
            label31.Text = ArrayOut10.Text;
            label30.Text = ArrayOut11.Text;
            label29.Text = ArrayOut12.Text;
            button5.Visible = true;
            button5.Focus();
            button6.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я' || l == '8' || l == '.')
                e.Handled = true; 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// введение намеренной ошибки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            ArrayOut1.Text = ArrayIn1.Text;
            ArrayOut2.Text = ArrayIn2.Text;
            ArrayOut3.Text = ArrayIn3.Text;
            ArrayOut4.Text = ArrayIn4.Text;
            ArrayOut5.Text = ArrayIn5.Text;
            ArrayOut6.Text = ArrayIn6.Text;
            ArrayOut7.Text = ArrayIn7.Text;
            ArrayOut8.Text = ArrayIn8.Text;
            ArrayOut9.Text = ArrayIn9.Text;
            ArrayOut10.Text = ArrayIn10.Text;
            ArrayOut11.Text = ArrayIn11.Text;
            ArrayOut12.Text = ArrayIn12.Text;
            button6.Visible = true;
            button6.Focus();
            button4.Visible = false;
            buttonForError.Visible = false;
            int[] ssout = new int[] {   Convert.ToInt16(ArrayOut3.Text), Convert.ToInt16(ArrayOut5.Text), 
                                        Convert.ToInt16(ArrayOut6.Text), Convert.ToInt16(ArrayOut7.Text), 
                                        Convert.ToInt16(ArrayOut9.Text), Convert.ToInt16(ArrayOut10.Text),
                                        Convert.ToInt16(ArrayOut11.Text), Convert.ToInt16(ArrayOut12.Text) };
            var number = new Random().Next(0, ssout.Length);
            ssout[number] = (ssout[number] + 1) % 2;
            ArrayOut3.Text = ssout[0].ToString();
            ArrayOut5.Text = ssout[1].ToString();
            ArrayOut6.Text = ssout[2].ToString();
            ArrayOut7.Text = ssout[3].ToString();
            ArrayOut9.Text = ssout[4].ToString();
            ArrayOut10.Text = ssout[5].ToString();
            ArrayOut11.Text = ssout[6].ToString();
            ArrayOut12.Text = ssout[7].ToString();
         }
    }
}
