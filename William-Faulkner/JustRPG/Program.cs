namespace JustRpg
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader("../../Art/Intro.txt"))
            {
                var x = sr.ReadLine();

                while(x != null)
                {
                    Console.WriteLine(x);
                    x = sr.ReadLine();
                }
            }
        }
    }
}
