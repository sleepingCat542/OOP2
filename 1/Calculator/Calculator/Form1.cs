using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public int с { get; private set; }
        public int c = 2;
        Calc Calculation;
        public Form1()
        {
            Calculation = new Calc();
            InitializeComponent();
        }

        public void ScaleOfNotation(int prevSyst, int nextSyst)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, prevSyst), nextSyst);
        }

        public void NoValue()
        {
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("Для проведения операции введите значение");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 9;
            try
            {
                if (textBox1.Text.Length > 9)
                    throw new Exception("Максимальный размер строки 9 символов");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Calculation.num1 = 0;
            Calculation.num2 = 0;
            с = 2;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string cancel = textBox1.Text;
                if (cancel.Length == 0)
                {
                    throw new Exception("Отмена ввода невозможна, так как строка пуста");
                }
                else
                {
                    cancel = cancel.Substring(0, cancel.Length - 1);
                    textBox1.Text = cancel;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 2);
            c = 2;
            Calculation.num2 = Convert.ToInt32(textBox1.Text, 2);
            switch (Calculation.operation)
            {
                case "or":
                    textBox1.Text = Convert.ToString((Calculation.num1 | Calculation.num2), 2);
                    break;
                case "and":
                    textBox1.Text = Convert.ToString((Calculation.num1 & Calculation.num2),2);
                    break;
                case "xor":
                    textBox1.Text = Convert.ToString((Calculation.num1 ^ Calculation.num2), 2);
                    break;
            }
        }

        private void buttonAnd_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 2);
            c = 2;
            Calculation.num1 = Convert.ToInt32(textBox1.Text, 2);
            Calculation.operation = "and";
            textBox1.Clear();
        }

        private void buttonOr_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 2);
            c = 2;
            Calculation.num1 = Convert.ToInt32(textBox1.Text, 2);
            Calculation.operation = "or";
            textBox1.Clear();
 
        }

        private void buttonXor_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 2);
            c = 2;
            Calculation.num1 = Convert.ToInt32(textBox1.Text, 2);
            Calculation.operation = "xor";
            textBox1.Clear();
        }

        private void buttonNot_Click(object sender, EventArgs e)
        {
            NoValue();
            if (c == 2)
            {
                string s = textBox1.Text;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '0')
                    {
                        s = s.Insert(i, "1");
                        s = s.Remove(i + 1, 1);
                    }
                    else
                    {
                        s = s.Insert(i, "0");
                        s = s.Remove(i + 1, 1);
                    }
                }
                textBox1.Text = s;
            }
            else
                MessageBox.Show("Приведите число в 2-ую систему");
        }

        private void buttonNum_Click(object sender, EventArgs e)//sender-эта кнопочка, EventArgs доп. данные
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void buttonTo2_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 2);
            c = 2;
        }

        private void buttonTo8_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 8);
            c = 8;
        }

        private void buttonTo16_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 16);
            c = 16;
        }

        private void buttonTo10_Click(object sender, EventArgs e)
        {
            NoValue();
            ScaleOfNotation(c, 10);
            c = 10;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Back && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D0 && e.KeyCode != Keys.NumPad1
                    && e.KeyCode != Keys.NumPad0 && e.KeyCode != Keys.Delete)
                {
                    throw new Exception("Использование данной клавиши невозможно");
                }
                else if(e.KeyCode == Keys.Delete)
                {
                    buttonC_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                textBox1.Clear();
                MessageBox.Show(ex.Message);
            }
        }
    }
}

