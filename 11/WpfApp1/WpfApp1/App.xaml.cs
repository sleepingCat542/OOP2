using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Models;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Disciplines> dist = new List<Disciplines>()
            {
                new Disciplines("Социология", "Подручный", 24, 40),
                new Disciplines("Квантовая теория", "Зелёнкин", 62, 70),
                new Disciplines("Философия", "Подручный", 24, 50),
                new Disciplines("Астрономия", "Гребень", 40, 50)
            };

            MainView view = new MainView(); // создали View
            MainViewModel viewModel = new ViewModels.MainViewModel(dist); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}
