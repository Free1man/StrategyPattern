using System;
using StrategyPattern.Fly;
using StrategyPattern.SpecificDucks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallaerdDuck();
            mallard.PreformFly();
            mallard.PreformQuack();

            Console.ReadLine();

            Duck modelDuck = new ModelDuck();
            modelDuck.PreformFly();
            modelDuck.FlyBehavior = new FlyRocketPowered();
            modelDuck.PreformFly();
            modelDuck.PreformQuack();

            Console.ReadLine();

        }
    }
}
