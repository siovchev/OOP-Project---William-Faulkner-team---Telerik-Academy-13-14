namespace JustRpg.Units
{
    using System;
    using System.Collections.Generic;
    using JustRpg.Interfaces;

    public abstract class Unit
    {
        private List<ISkill> skills;
        public Unit(int hitP, int attP, int defP, int speed)
        {
            this.HitPoints = hitP;
            this.AttackPoints = attP;
            this.DefensePoints = defP;
            this.Speed = speed;
            skills = new List<ISkill>();
        }
       
        public int HitPoints { get; protected set; }

        public int AttackPoints { get; protected set; }

        public int DefensePoints { get; protected set; }

        public int Speed { get; protected set; }

        

        // Returning all the skills for a given unit 
        public List<ISkill> GetSkills
        {
            get
            {
                return this.skills;
            }
            protected set
            {
                this.skills = value;
            }
        }


    }
}
