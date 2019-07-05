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
    /// Логика взаимодействия для UserAcc.xaml
    /// </summary>
    public partial class UserAcc : UserControl
    {
        public UserAcc()
        {
            InitializeComponent();
        }
        public ImageSource userImage
        {
            get { return UserImage.Source; }
            set { UserImage.Source = value; }
        }
        public string userName
        {
            get { return UserName.Text; }
            set { UserName.Text = value; }
        }


        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Чтобы взять котика вам нужно авторизоваться!", "Ой!");
        }
    }

    public class CustomCommand
    {
        private static RoutedUICommand newCommand;
        static CustomCommand()//создание команды пользователя
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.P, ModifierKeys.Alt, "Alt+P"));
            newCommand = new RoutedUICommand("NeW", "NeW", typeof(CustomCommand), inputs);//текст, имя команды, горячие клавиши
        }
        public static RoutedUICommand NewCommand
        {
            get { return newCommand; }
        }
    }
}

