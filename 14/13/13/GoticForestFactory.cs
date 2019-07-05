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
    class GoticForestFactory : AbstractFactory
    {
        public override UIElement CreateLake()
        {
            UserControl1 lake2 = new UserControl1();
            lake2.Light.Offset = 1;
            lake2.Dark.Offset = 0.382;
            lake2.Dark.Color = (Color)ColorConverter.ConvertFromString("#FFED1E2D");
            lake2.Light.Color = (Color)ColorConverter.ConvertFromString("#FF050202");
            lake2.Width = 100;
            return lake2;
        }

        public override UIElement CreateTree()
        {
            UserControl2 tree2 = new UserControl2();
            tree2.EL.Width = 110;
            tree2.EL.Height = 220;
            tree2.EL.Margin = new Thickness(18.099,10,0,0);
            tree2.Dark.Color = (Color)ColorConverter.ConvertFromString("#FF140723");
            tree2.Light.Color = (Color)ColorConverter.ConvertFromString("#FF810EF9");
            return tree2;
        }
    }
}
