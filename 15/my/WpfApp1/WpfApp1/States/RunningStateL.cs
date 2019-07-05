using _15.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Commands;

namespace WpfApp1.States
{
    class RunningStateL:IState
    {
        public RunningStateL(Hero hero)
        {
            new RunCommandL().Execute(hero.hero);
        }

        public void HandleInput(Hero hero, char input)
        {
            if (input == 'D')
                hero.State = new RunningState(hero);
            else if (input == 'W')
                hero.State = new JumpingState(hero);
            else if (input == 'A')
                hero.State = new RunningStateL(hero);
        }

        public void Update(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
