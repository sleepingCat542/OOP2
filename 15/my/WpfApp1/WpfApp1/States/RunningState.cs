using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.States
{
    using Commands;
    using WpfApp1;
    using WpfApp1.States;

    class RunningState : IState
    {
        public RunningState(Hero hero)
        {
            new RunCommand().Execute(hero.hero);
        }

        public void HandleInput(Hero hero, char input)
        {
            if (input == 'A')
                hero.State = new RunningStateL(hero);
            else if (input == 'W')
                hero.State = new JumpingState(hero);
            else if (input == 'D')
                hero.State = new RunningState(hero);
        }

        public void Update(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
