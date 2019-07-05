using _15.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Commands
{
    class RunCommandL : ICommand
    {
        public void Execute(UserControl1 hero)
        {
            Thickness margin = hero.Margin;
            margin.Left = margin.Left - 100;
            hero.Margin = margin;
        }
    }
}
