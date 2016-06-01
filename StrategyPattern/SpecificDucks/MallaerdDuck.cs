using System;
using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.SpecificDucks
{
    public class MallaerdDuck : Duck
    {
        public MallaerdDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Dispaly()
        {
            Console.WriteLine("I'm a real Mallaerd Duck");
        }
    }
}
