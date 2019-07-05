using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.States
{
    using Commands;
    using WpfApp1;

    class JumpingState : IState
    {
        public JumpingState(Hero hero)
        {            
            new JumpCommand().Execute(hero.hero);
        }

        public void HandleInput(Hero hero, char input)
        {
            if (input == 'S')
                hero.State = new StandingState(hero);
        }

        public void Update(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
