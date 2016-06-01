using System;
using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.SpecificDucks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Dispaly()
        {
            Console.WriteLine("I'm a real ModelDuck");
        }
    }
}
