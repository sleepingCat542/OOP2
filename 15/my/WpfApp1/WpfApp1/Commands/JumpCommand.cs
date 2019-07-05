using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1;

namespace _15.Commands
{
    class JumpCommand : ICommand
    {
        public void Execute(UserControl1 hero)
        {            
            Thickness margin = hero.Margin;
            margin.Top = margin.Top-140;
            hero.Margin = margin;
        }
    }
}
