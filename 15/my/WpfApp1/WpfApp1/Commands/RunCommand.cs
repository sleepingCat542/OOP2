using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1;

namespace _15.Commands
{
    class RunCommand : ICommand
    {
        public void Execute(UserControl1 hero)
        {
            Thickness margin = hero.Margin;
            margin.Left = margin.Left+100;
            hero.Margin = margin;
        }
    }
}
