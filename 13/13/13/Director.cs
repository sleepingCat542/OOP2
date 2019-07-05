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
    class Director : IDirector, IPrototype
    {
        private IBuilder m_builder;
        private List<UIElement> m_result;

        public Director(IBuilder builder)
        {
            m_builder = builder;
        }

        public IPrototype Clone()
        {
            Director newDir = new Director(m_builder);
            newDir.m_result = m_result.Select(item => item).ToList();
            return newDir;
        }

        public void CreateComplexItem(double x, double y)
        {
            UserControl1 userControl1= m_builder.CreateBackgroundItem() as UserControl1;
            UserControl2 userControl21 = m_builder.CreateForegroundItem() as UserControl2;
            UserControl2 userControl22 = m_builder.CreateForegroundItem() as UserControl2;
            UserControl2 userControl23 = m_builder.CreateForegroundItem() as UserControl2;

            Thickness backgroundMargin = userControl1.Margin;
            backgroundMargin.Left = x;
            backgroundMargin.Top = y;
            userControl1.Margin = backgroundMargin;

            Thickness foregroundMargin = userControl21.Margin;
            foregroundMargin.Left = x - 100;
            foregroundMargin.Top = y-190;
            userControl21.Margin = foregroundMargin;

            Thickness foregroundMargin2 = userControl22.Margin;
            foregroundMargin2.Left = x + 90;
            foregroundMargin2.Top = y-190;
            userControl22.Margin = foregroundMargin2;

            Thickness foregroundMargin3 = userControl23.Margin;
            foregroundMargin3.Left = x;
            foregroundMargin3.Top = y-190;
            userControl23.Margin = foregroundMargin3;

            m_result = new List<UIElement>();
            m_result.Add(userControl1);
            m_result.Add(userControl21);
            m_result.Add(userControl22);
            m_result.Add(userControl23);
        }

        public List<UIElement> GetResult()
        {
            return m_result;
        }
    }
}
