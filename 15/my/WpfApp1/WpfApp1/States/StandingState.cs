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

    class StandingState : IState
    {
        public StandingState(Hero hero)
        {
            new StandCommand().Execute(hero.hero);
        }

        public StandingState()
        {
            new StandCommand().ExecuteBegin();
        }

        public void HandleInput(Hero hero, char input)
        {
            if (input == 'D')
                hero.State = new RunningState(hero);
            else if (input == 'A')
                hero.State = new RunningStateL(hero);
            else if (input == 'W')
                hero.State = new JumpingState(hero);
        }

        public void Update(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
