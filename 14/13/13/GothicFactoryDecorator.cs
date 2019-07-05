using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp2;

namespace _13
{
    class GothicFactoryDecorator : AbstractFactory
    {
        GoticForestFactory m_factory;

        public GothicFactoryDecorator(GoticForestFactory factory)
        {
            m_factory = factory;
        }

        public override UIElement CreateLake()
        {
            UIElement el = m_factory.CreateLake();
            ToText(el);
            return ToTall(el);
        }

        public override UIElement CreateTree()
        {
            UIElement el = m_factory.CreateTree();
            ToText(el);
            return ToTall(el);
        }

        private UIElement ToTall(UIElement source)
        {
            if (source.ToString() == "WpfApp2.UserControl2")
            {
                UserControl2 uc = source as UserControl2;
                uc.EL.Width = 90;
                uc.EL.Height = 270;
                uc.EL.Margin = new Thickness(26, 0, 0, 5);
                return uc as UIElement;
            }
            else
            {
                UserControl1 uc = source as UserControl1;
                uc.Dark.Color = (Color)ColorConverter.ConvertFromString("Black");
                uc.Light.Color = (Color)ColorConverter.ConvertFromString("Yellow");
                return uc as UIElement;
            }
        }

        private void ToText(UIElement source)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Width = 100;
            toolTip1.Height = 30;
            toolTip1.FontSize = 10;

            if (source.ToString() == "WpfApp2.UserControl2")
            {
                UserControl2 uc = (UserControl2)source;
                toolTip1.Content = "Дерево";
                uc.ToolTip = toolTip1;
            }

            else
            {
                UserControl1 uc = (UserControl1)source;
                toolTip1.Content = "Озеро";
                uc.ToolTip = toolTip1;
            }



        }
    }
}
