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
using WpfApp2;

namespace _13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void create_click(object sender, RoutedEventArgs e)
        {
            CreateDialog dialog = new CreateDialog();
            dialog.Owner = this;
            dialog.ShowDialog();
            var items = dialog.Elements;
            Random randomGenerator = new Random();
            foreach(var item in items)
            {
                grid.Children.Add(item);
                if (item.ToString() == "WpfApp2.UserControl2")
                {
                    UserControl2 rectElement = (UserControl2)item;
                    TreeAdapter adapter = new TreeAdapter(rectElement);
                    adapter.X = randomGenerator.Next(0, (int)(Width + 40));
                    adapter.Y = randomGenerator.Next(0, (int)(Height + 20));
                    //Thickness margin = rectElement.Margin;
                    //margin.Left = randomGenerator.Next(0, (int)(Width+40));
                    //margin.Top = randomGenerator.Next(0, (int)(Height+20));
                    //rectElement.Margin = margin;
                }
                else
                {
                    UserControl1 rectElement = (UserControl1)item;
                    Thickness margin = rectElement.Margin;
                    margin.Left = randomGenerator.Next(0, (int)(Width - 100));
                    margin.Top = randomGenerator.Next(0, (int)(Height - 100));
                    rectElement.Margin = margin;
                }

            }
        }

        private void createComplex_click(object sender, RoutedEventArgs e)
        {
            Builder builder = new Builder();
            Director director = new Director(builder);
            director.CreateComplexItem(120, 120);
            List<UIElement> list = director.GetResult();
            foreach (var element in list)
                grid.Children.Add(element);
        }
    }
}
