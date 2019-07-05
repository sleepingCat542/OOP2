using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    using _15.States;
    class Hero
    {
        public IState State { get; set; }
        public UserControl1 hero;

        public void HandleInput(char input)
        {
            State.HandleInput(this, input);
        }

        public Hero()
        {
            this.hero=new UserControl1();
            State = new StandingState();
        }
    }
}
