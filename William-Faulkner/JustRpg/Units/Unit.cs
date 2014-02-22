namespace JustRpg.Units
{
    using System;
    using System.Collections.Generic;
    
    using JustRpg.EngineAndRenderer;
    using JustRpg.Interfaces;

    public abstract class Unit : IRenderable
    {
        private List<ISkill> skills;
        protected MatrixCoords topLeft;
        protected char[,] body;

        public Unit(int hitP, int attP, int defP, int speed)
        {
            this.HitPoints = hitP;
            this.AttackPoints = attP;
            this.DefensePoints = defP;
            this.Speed = speed;
            skills = new List<ISkill>();
        }

        public MatrixCoords TopLeft
        {
            get
            {
                return new MatrixCoords(this.topLeft.Row, this.topLeft.Col);
            }

            protected set
            {
                this.topLeft = new MatrixCoords(value.Row, value.Col);
            }
        }

        public bool IsDestroyed { get; protected set; }
       
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

        public MatrixCoords GetTopLeft()
        {
            return this.topLeft;
        }

        public char[,] GetImage()
        {
            return this.body;
        }
    }
}