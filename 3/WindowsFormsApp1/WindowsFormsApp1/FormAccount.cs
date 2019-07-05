using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class FormAccount : Form
    {
        public Account acc = new Account();
        public History histor = new History();
        public Owner owne = new Owner();
        public List<Account> accs = new List<Account>();
        public List<Account> sort = new List<Account>();
        public List<Account> search = new List<Account>();//для хранения результатов поиска
        public FormAccount()
        {
            InitializeComponent();
            buttonView.Enabled = false;
            textBoxBalance.Tag = false;
            textBoxNumber.Tag = false;
            comboBox1.Items.AddRange(acc.listOfDepositType);
            comboBox1.Text = comboBox1.Items[0].ToString();
            acc.number=textBoxNumber.Text;
            acc.balance = textBoxBalance.Text;
            acc.openingDate=dateOpen.Text;
            acc.internetBanking = radioButtonInternet1.AutoCheck;
            acc.smsAlert = radioButtonSms1.AutoCheck;
            timer1.Start();
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
                using (FileStream fs = new FileStream("accss.xml", FileMode.Create))
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
                if (!Validate(acc))
                    return;
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


            private void поДатеОткрытияСчётаToolStripMenuItem_Click(object sender, EventArgs e)//сортировка по дате открытия
            {
            textBox1.Clear();
            XDocument xdoc = XDocument.Load(@"H:\ООП\Лабы\laba3\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\accs.xml");

            XElement xmlTree = new XElement("Root");//создание дерева

            IEnumerable<XElement> xElms;
            xElms = from t in xdoc.Root.Elements("Account")
                    orderby t.Element("openingDate").Value
                    select t;
            foreach (XElement a in xElms)
            {
                textBox1.Text += "Номер:" + a.Element("number").Value + "Фамилия:" + a.Element("Owner").Element("Surname").Value + "Дата открытия:" + a.Element("openingDate").Value + Environment.NewLine;
                xmlTree.Add(new XElement(a));
            }
            xdoc.Save("Dsore.xml");


            sort.Clear();
            var result2 = accs
                    .OrderBy(ev => ev.openingDate)
                    .Select(ev => ev);
            int i = 1;
            foreach (Account a in result2)
            {
                sort.Add(a);
                i++;
            }
            
        }

            private void AboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)//О программе...
        {
            MessageBox.Show("Версия 2.0\nРазработчик: Хадасевич Ю.А.", "О программе");
        }

        private void SearchResultToolStripMenuItem_Click(object sender, EventArgs e)//сохранение результатов поиска
        {
            try
            {
                FormSearch formSearch = new FormSearch(this);
                if (search.Count==0)
                {
                    throw new Exception("Возможно, результатов поиска не обнаружено!");
                }
                else
                {
                    using (FileStream fs = new FileStream("search.xml", FileMode.Create))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));
                        formatter.Serialize(fs, search);
                    }
                    MessageBox.Show("Результаты поиска сохранены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void SortResultToolStripMenuItem_Click(object sender, EventArgs e)//сохранение результатов сортировки
        {
            try
            {
                    if (textBox1.Text != "")
                    {
                        using (FileStream fs = new FileStream("sort.xml", FileMode.Create))
                        {
                            XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));
                            formatter.Serialize(fs, sort);
                        }
                    }
                    else
                    {
                        throw new Exception("Возможно, результатов сортировки по частоте процессора не обнаружено!");
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)//кнопка формы поиска
        {
            FormSearch formSearch = new FormSearch(this);
            formSearch.ShowDialog();
            if (formSearch.result != null)
            {
                search = formSearch.result;
            }
        }

        private void TypeToolStripMenuItem_Click(object sender, EventArgs e)//сортировка по типу
        {
            textBox1.Clear();
            XDocument xdoc = XDocument.Load(@"H:\ООП\Лабы\laba3\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\accs.xml");
            XDocument xdoc2= XDocument.Load("sortT.xml");

            XElement xmlTree = new XElement("Root");//создание дерева

            IEnumerable<XElement> xElms;
            xElms = from t in xdoc.Root.Elements("Account")
                         orderby t.Element("depositType").Value
                         select t;
            foreach (XElement a in xElms)
            {
                textBox1.Text += "Номер:" + a.Element("number").Value + "Фамилия:" + a.Element("Owner").Element("Surname").Value + "Тип вклада:" + a.Element("depositType").Value + Environment.NewLine;
                xmlTree.Add(new XElement(a));
            }
            xdoc.Save("Tsore.xml");


            sort.Clear();
            var result2 = accs
                    .OrderBy (ev=>ev.depositType)
                    .Select (ev=>ev);
            int i = 1;
            foreach (Account a in result2)
            {
                sort.Add(a);
                i++;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(this);
            formSearch.ShowDialog();
            if (formSearch.result != null)
            {
                search = formSearch.result;
            }
        }

        private void результатСортировкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    using (FileStream fs = new FileStream("sort.xml", FileMode.Create))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));
                        formatter.Serialize(fs, sort);
                    }
                }
                else
                {
                    throw new Exception("Возможно, результатов сортировки по частоте процессора не обнаружено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void результатПоискаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FormSearch formSearch = new FormSearch(this);
                if (search.Count == 0)
                {
                    throw new Exception("Возможно, результатов поиска не обнаружено!");
                }
                else
                {
                    using (FileStream fs = new FileStream("search.xml", FileMode.Create))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));
                        formatter.Serialize(fs, search);
                    }
                    MessageBox.Show("Результаты поиска сохранены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void поТипуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            XDocument xdoc = XDocument.Load(@"H:\ООП\Лабы\laba3\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\accs.xml");
            XDocument xdoc2 = XDocument.Load("sortT.xml");

            XElement xmlTree = new XElement("Root");//создание дерева

            IEnumerable<XElement> xElms;
            xElms = from t in xdoc.Root.Elements("Account")
                    orderby t.Element("depositType").Value
                    select t;
            foreach (XElement a in xElms)
            {
                textBox1.Text += "Номер:" + a.Element("number").Value + "Фамилия:" + a.Element("Owner").Element("Surname").Value + "Тип вклада:" + a.Element("depositType").Value + Environment.NewLine;
                xmlTree.Add(new XElement(a));
            }
            xdoc.Save("Tsore.xml");


            sort.Clear();
            var result2 = accs
                    .OrderBy(ev => ev.depositType)
                    .Select(ev => ev);
            int i = 1;
            foreach (Account a in result2)
            {
                sort.Add(a);
                i++;
            }
        }

        private void поДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            XDocument xdoc = XDocument.Load(@"H:\ООП\Лабы\laba3\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\accs.xml");

            XElement xmlTree = new XElement("Root");//создание дерева

            IEnumerable<XElement> xElms;
            xElms = from t in xdoc.Root.Elements("Account")
                    orderby t.Element("openingDate").Value
                    select t;
            foreach (XElement a in xElms)
            {
                textBox1.Text += "Номер:" + a.Element("number").Value + "Фамилия:" + a.Element("Owner").Element("Surname").Value + "Дата открытия:" + a.Element("openingDate").Value + Environment.NewLine;
                xmlTree.Add(new XElement(a));
            }
            xdoc.Save("Dsore.xml");


            sort.Clear();
            var result2 = accs
                    .OrderBy(ev => ev.openingDate)
                    .Select(ev => ev);
            int i = 1;
            foreach (Account a in result2)
            {
                sort.Add(a);
                i++;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }
        #region status
        private void button_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Нажмите для ввода дополнительной информации";
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void buttonShow_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Вывод текущего объекта";
        }

        private void buttonClear_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Очистить окно вывода";
        }

        private void buttonSaveXML_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Сохранить текущий объект";
        }

        private void buttonShowXML_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Вывод всей информации из файла";
        }
        #endregion

        private void Show_Count(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel4.Text =  $"Сейчас у нас {accs.Count} объектов";
        }

        private bool Validate(Account model)
        {
            var resul = new List<ValidationResult>();
            var context = new ValidationContext(model);
            if (!Validator.TryValidateObject(model, context, resul, true))
            {
                string strWithErrroe = "";
                foreach (var error in resul)
                    strWithErrroe += $"{error.ErrorMessage}\n";

                MessageBox.Show(strWithErrroe);
            }
            return !resul.Any();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            acc.number = textBoxNumber.Text;
        }
    }
}
    

