using System;

namespace StrategyPattern.Fly
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a Rocket");
        }
    }
}
