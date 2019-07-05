using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2;

namespace _13
{
    class TreeAdapter
    {
        private UserControl2 m_element;
        public TreeAdapter(UserControl2 element)
        {
            m_element = element;
        }
        public TreeAdapter(UIElement element)
        {
            m_element = element as UserControl2;
        }
        public double X
        {
            get
            {
                return m_element.Margin.Left;
            }
            set
            {
                Thickness margin = m_element.Margin;
                margin.Left = value;
                m_element.Margin = margin;
            }
        }
        public double Y
        {
            get { return m_element.Margin.Top; }
            set
            {
                Thickness margin = m_element.Margin;
                margin.Top = value;
                m_element.Margin = margin;
            }
        }
    }
}
