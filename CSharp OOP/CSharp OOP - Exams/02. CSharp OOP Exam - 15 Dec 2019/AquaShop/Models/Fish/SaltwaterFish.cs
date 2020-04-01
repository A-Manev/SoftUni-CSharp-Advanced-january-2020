﻿namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private const int INITIAL_SIZE = 5;

        public SaltwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {

        }

        public int Size => INITIAL_SIZE;

        public override void Eat()
        {
            base.Size += 2;
        }
    }
}
