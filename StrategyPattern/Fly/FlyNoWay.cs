﻿using System;

namespace StrategyPattern.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I CAN'T fly :(");
        }
    }
}
