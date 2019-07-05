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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hero hero;
        public MainWindow()
        {
            InitializeComponent();
            this.hero = new Hero();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hero.HandleInput('S');
            grid.Children.Add(hero.hero);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            char inp;
            if (e.Key.ToString().Length > 1)
            {
                throw new Exception("Введена не та клавиша");
            }
            else
            {
            inp = Convert.ToChar(e.Key.ToString());
            hero.HandleInput(inp);
            }
            }
            catch(Exception ex)
            {
              
                MessageBox.Show(ex.Message);
            }
        }
    }
}
