using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class FormSearch : Form
    {
        public List<Account> result = new List<Account>();
        public FormAccount data;
        public List<string> chbList=new List<string>(); 

        public string surname;
        public string type;
        public string balance;
        public string number;


        public FormSearch()
        {
            InitializeComponent();
        }

        public FormSearch(FormAccount accounts)
        {
            InitializeComponent();
            data = accounts;
        }

        private void Fill(Account account)//заполнение DataGrid
        {
            DataGridViewCell Number = new DataGridViewTextBoxCell();
            DataGridViewCell Name = new DataGridViewTextBoxCell();
            DataGridViewCell Balance = new DataGridViewTextBoxCell();
            DataGridViewCell Alert = new DataGridViewTextBoxCell();
            DataGridViewCell Banking = new DataGridViewTextBoxCell();
            DataGridViewCell Type = new DataGridViewTextBoxCell();
            DataGridViewCell Data = new DataGridViewTextBoxCell();

            Number.Value = account.number;
            Name.Value = account.Owner.Surname;
            Balance.Value = account.balance;
            Alert.Value = account.smsAlert;
            Banking.Value = account.internetBanking;
            Type.Value = account.depositType;
            Data.Value = account.openingDate;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(Number, Name, Type, Balance, Data, Alert, Banking);
            dataGridView1.Rows.Add(row);
        }


        private void button1_Click(object sender, EventArgs e)//поиск
        {
            try
            {
                if (radioButton1.Checked)
                {
                    number = textBox5.Text;
                    if (number == "")
                        textBox5.BackColor = Color.Tomato;
                    else
                    {
                        textBox5.BackColor = Color.White;
                        Regex regexN;
                        result.Clear();
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < data.accs.Count(); i++)
                        {
                            char n = number[0];
                            regexN = new Regex(@"" + n + @"\w*", RegexOptions.IgnoreCase);
                            Match match = regexN.Match(data.accs[i].number);
                            if (match.Success)
                            {

                                result.Add(data.accs[i]);
                                Fill(data.accs[i]);
                            }
                        }
                    }
                }
                if (radioButton2.Checked)
                {
                    surname = textBox5.Text;
                    if (surname == "")
                        textBox5.BackColor = Color.Tomato;
                    else
                    {
                        textBox5.BackColor = Color.White;
                        Regex regexN;
                        result.Clear();
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < data.accs.Count(); i++)
                        {
                            char n = surname[0];
                            regexN = new Regex(@"" + n + @"\w*", RegexOptions.IgnoreCase);
                            Match match = regexN.Match(data.accs[i].Owner.Surname);
                            if (match.Success)
                            {
                                result.Add(data.accs[i]);
                                Fill(data.accs[i]);
                            }
                        }
                    }
                }
                if (radioButton3.Checked)
                {
                    type = textBox5.Text;
                    if (type == "")
                        textBox5.BackColor = Color.Tomato;
                    else
                    {
                        textBox5.BackColor = Color.White;
                        Regex regexN;
                        result.Clear();
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < data.accs.Count(); i++)
                        {
                            char n = type[0];
                            regexN = new Regex(@"" + n + @"\w*", RegexOptions.IgnoreCase);
                            Match match = regexN.Match(data.accs[i].depositType);
                            if (match.Success)
                            {
                                result.Add(data.accs[i]);
                                Fill(data.accs[i]);
                            }
                        }
                    }
                }
                if (radioButton4.Checked)
                {
                    balance = textBox5.Text;
                    if (balance == "")
                        textBox5.BackColor = Color.Tomato;
                    else
                    {
                        textBox5.BackColor = Color.White;
                        Regex regexN;
                        result.Clear();
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < data.accs.Count(); i++)
                        {
                            char n = balance[0];
                            regexN = new Regex(@"" + n + @"\w*", RegexOptions.IgnoreCase);
                            Match match = regexN.Match(data.accs[i].balance);
                            if (match.Success)
                            {
                                result.Add(data.accs[i]);
                                Fill(data.accs[i]);
                            }
                        }
                    }
                }
                if (radioButton4.Checked==false && radioButton3.Checked == false && radioButton2.Checked == false && radioButton1.Checked == false)
                    throw new Exception("Нет информации для поиска");
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
            }
            }



        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//"Ок" закрываем окно
        {
            Close();
            data.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
