namespace JustRpg
{
    using System;
    using System.IO;
    using JustRpg.EngineAndRenderer;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        public static void DrawTestIntro()
        {
            using (StreamReader sr = new StreamReader("../../Art/Intro.txt"))
            {
                var x = sr.ReadLine();

                while (x != null)
                {
                    Console.WriteLine(x);
                    x = sr.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            var engine = Engine.CurrentInstance;
            
            DrawTestIntro();
        }
    }
}