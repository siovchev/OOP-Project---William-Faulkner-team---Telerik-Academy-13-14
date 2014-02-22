namespace JustRpg.Units
{
    using System;

    class HeroBarbarian : Hero
    {
        private const int initialHitPoints = 600;
        private const int initialAttackPoints = 20;
        private const int initialDefencePoints = 10;
        private const int initialSpeed = 1;

        public HeroBarbarian(string name) 
            : base(name, initialHitPoints, initialAttackPoints, initialDefencePoints, initialSpeed)
        {
        }
    }
}
