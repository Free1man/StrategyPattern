using System;
using StrategyPattern.Fly;
using StrategyPattern.Quack;


namespace StrategyPattern
{

    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;

        public IFlyBehavior FlyBehavior
        {
            get { return _flyBehavior; }
            set { _flyBehavior = value; }
        }

        private IQuackBehavior _quackBehavior;

        public IQuackBehavior QuackBehavior
        {
            get { return _quackBehavior; }
            set { _quackBehavior = value; }
        }
     
        public abstract void Dispaly();

      
        public void PreformFly()
        {
            FlyBehavior.Fly();
        }

        public void PreformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

       


    }
}
