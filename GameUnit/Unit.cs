using System;
using Humanizer;

namespace GameUnit
{
    public abstract class Unit
    {
        // Values
        private readonly int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        //Methods
        public void Move(int movement)
        {
            Console.WriteLine($"This Unit moved {movement.ToRoman()} houses");
        }
    }
}
