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
    class ChildrenForestFactory : AbstractFactory
    {
        public override UIElement CreateLake()
        {
            UserControl1 lake1 = new UserControl1();
            lake1.Light.Offset = 0.538;
            lake1.Width = 70;
            return lake1;
        }

        public override UIElement CreateTree()
        {
            UserControl2 tree1 = new UserControl2();
            return tree1;
        }
    }
}
