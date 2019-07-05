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
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class FormAccount : Form
    {
        public Account acc = new Account();
        public History histor = new History();
        public Owner owne = new Owner();
        public List<Account> accs = new List<Account>();
        public FormAccount()
        {
            InitializeComponent();
            buttonView.Enabled = false;
            textBoxBalance.Tag = false;
            textBoxNumber.Tag = false;
            //comboBox1.Tag = false;
            comboBox1.Items.AddRange(acc.listOfDepositType);
            comboBox1.Text = comboBox1.Items[0].ToString();
            acc.number=textBoxNumber.Text;
            acc.balance = textBoxBalance.Text;
            acc.openingDate=dateOpen.Text;
            acc.internetBanking = radioButtonInternet1.AutoCheck;
            acc.smsAlert = radioButtonSms1.AutoCheck;
        }

        private void ToHistory_Click(object sender, EventArgs e)
        {            
            try
            {
                if (textBoxBalance.Text == "")
                    throw new Exception("Для добавления операции введите баланс");
                FormHistory his = new FormHistory(this);
                his.ShowDialog();
                acc.History = histor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToOwner_Click(object sender, EventArgs e)
        {
            try
            {
                FormOwner own = new FormOwner(this);
                own.ShowDialog();
                acc.Owner = owne;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TypeChange(object sender, EventArgs e)
        {
            ComboBox comboBox1 = (ComboBox)sender;
            acc.depositType = comboBox1.Text;
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.LightSalmon;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }
        private void ValidateOK()
        {
            buttonView.Enabled = ((bool)textBoxNumber.Tag && (bool)textBoxBalance.Tag);
        }
        private void Banking_Changed(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                acc.internetBanking = radioButton.Checked;
        }

        private void Sms_Changed(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                acc.smsAlert = radioButton.Checked;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            acc.number = textBoxNumber.Text;
            acc.balance = textBoxBalance.Text;
            acc.openingDate = dateOpen.Text;
            acc.depositType = comboBox1.Text;
            try
            {
                textBox2.Text = acc.ShowAllInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не предоставлено информации в дополнительных полях!");
            }
        }

        private void Balance_Click(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Back && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D0 && e.KeyCode != Keys.NumPad1
                    && e.KeyCode != Keys.NumPad0 && e.KeyCode != Keys.Delete && e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3
                    && e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 && e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7
                    && e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9 && e.KeyCode != Keys.NumPad2 && e.KeyCode != Keys.NumPad3
                    && e.KeyCode != Keys.NumPad4 && e.KeyCode != Keys.NumPad5 && e.KeyCode != Keys.NumPad6 && e.KeyCode != Keys.NumPad7
                    && e.KeyCode != Keys.NumPad8 && e.KeyCode != Keys.NumPad9)
                {
                    throw new Exception("Использование данной клавиши невозможно");
                }
            }
            catch (Exception ex)
            {
                textBoxBalance.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void Balance_enter(object sender, EventArgs e)
        {
            acc.balance = textBoxBalance.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void buttonInXML_Click(object sender, EventArgs e)
        {
            try
            {
                accs.Add(acc);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));
                using (FileStream fs = new FileStream("accs.xml", FileMode.Create))
                {
                    formatter.Serialize(fs, accs);
                }
                textBox2.Text = "";
                acc = new Account();
                comboBox1.Items.AddRange(acc.listOfDepositType);
                comboBox1.Text = comboBox1.Items[0].ToString();
                acc.number = textBoxNumber.Text;
                acc.balance = textBoxBalance.Text;
                acc.openingDate = dateOpen.Text;
                acc.internetBanking = radioButtonInternet1.AutoCheck;
                acc.smsAlert = radioButtonSms1.AutoCheck;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void buttonFromXML_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));
                using (FileStream fs = new FileStream("accs.xml", FileMode.OpenOrCreate))
                {
                    accs = (List<Account>)formatter.Deserialize(fs);
                }
                textBox2.Text = "";
                foreach (var comp in accs)
                    textBox2.Text += comp.ShowAllInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка десериализации!");
            }
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateOpen_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
