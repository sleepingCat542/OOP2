using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormHistory : Form
    {
        FormAccount MainForm;
        public FormHistory(FormAccount Main)
        {
            MainForm = Main;
            InitializeComponent();
            comboBox1.Items.AddRange(MainForm.histor.operationType);
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void buttonSendHist_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (comboBox1.Text == "Перевод" || comboBox1.Text == "Снятие")
                {
                    int sum;
                    sum = (Convert.ToInt32(MainForm.acc.balance) - Convert.ToInt32(trackBar1.Value+"0"));
                    if (sum < 0)
                    {
                        throw new Exception("Недостаточно средств для выполнения операции");
                    }
                    MainForm.histor.count = label6.Text;
                    MainForm.acc.balance = Convert.ToString(sum);
                }
                else
                {
                    MainForm.histor.count = label6.Text;
                    MainForm.acc.balance = Convert.ToString(Convert.ToInt32(MainForm.acc.balance) + Convert.ToInt32(trackBar1.Value + "0"));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MainForm.histor.dataOfOreration = dateTimePicker1.Text;
            MainForm.histor.TypeOfOperation = comboBox1.Text;

            Close();
            MainForm.Show();
        }

        private void Scrol_count(object sender, EventArgs e)
        {
            label6.Text = "Сумма: " + trackBar1.Value+"0 рублей";
        }

        private void TypeChange(object sender, EventArgs e)
        {
            ComboBox comboBox1 = (ComboBox)sender;
            MainForm.histor.TypeOfOperation = comboBox1.Text;
        }

    }
}
