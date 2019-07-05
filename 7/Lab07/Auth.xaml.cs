using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab07
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : UserControl
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, MouseButtonEventArgs e) // bubbling (поднимающиеся)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n");
            Login.Text = "";
            Password.Text = "";
        }

        private void Press_Click(object sender, MouseButtonEventArgs e) // tunneling (опускающиеся/туннельные)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n");
            Login.Text = "";
            Password.Text = "";
        }

        private void Press_DirectClick(object sender, MouseButtonEventArgs e)   // direct (прямые)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n");
            Login.Text = "";
            Password.Text = "";
        }
    }
    
}
