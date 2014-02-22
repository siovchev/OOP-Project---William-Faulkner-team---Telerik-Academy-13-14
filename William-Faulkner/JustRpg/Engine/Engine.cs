namespace JustRpg.Engine
{
    using System;
    using System.Collections.Generic;

    using JustRpg.Units;

    public class Engine
    {
        private  Renderer renderer;
        private  List<Unit> units;

        public Engine()
        {
            this.renderer = new Renderer();
            this.units = new List<Unit>();
        }
    }
}
