using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using WpfApp2;

namespace _13
{
    class Builder : IBuilder
    {
        public UIElement CreateBackgroundItem()
        {
            UserControl1 la = new UserControl1();
            la.Width = 50;
            la.Height = 40;
            return la;
        }

        public UIElement CreateForegroundItem()
        {
            UserControl2 tr = new UserControl2();
            tr.Width = 20;
            tr.Height = 30;
            return tr;
        }
    }
}
