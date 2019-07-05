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
    public partial class FormOwner : Form
    {
        FormAccount MainForm;
        public FormOwner(FormAccount Main)
        {
            MainForm = Main;
            InitializeComponent();
            buttonSendOwn.Enabled = false;
            textBoxName.Tag = false;
            textBoxSurname.Tag = false;
            textBoxMidName.Tag = false;
            textBoxSer.Tag = false;
            textBoxNum.Tag = false;
        }

        private void buttonSendOwn_Click(object sender, EventArgs e)
        {
            MainForm.owne.Name = textBoxName.Text;
            MainForm.owne.Surname = textBoxSurname.Text;
            MainForm.owne.MidName = textBoxMidName.Text;
            MainForm.owne.passportSeries = textBoxSer.Text;
            MainForm.owne.passportId = textBoxNum.Text;
            MainForm.owne.Birthday = dateTimePicker1.Text;

            Close();
            MainForm.Show();
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
            buttonSendOwn.Enabled = ((bool)textBoxName.Tag &&
                (bool)textBoxSurname.Tag && (bool)textBoxMidName.Tag &&
                (bool)textBoxMidName.Tag && (bool)textBoxMidName.Tag);
        }

        private void NotWords_Clic(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
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
                tb.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void NotNumbers_Clic(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad1
                    || e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.Delete || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3
                    || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7
                    || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3
                    || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7
                    || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
                {
                    throw new Exception("Использование данной клавиши невозможно");
                }
            }
            catch (Exception ex)
            {
                tb.Clear();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
