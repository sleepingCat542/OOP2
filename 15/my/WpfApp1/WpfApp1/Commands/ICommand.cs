using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1;

namespace _15.Commands
{
    interface ICommand
    {
        void Execute(UserControl1 hero);
    }
}
