using System;
using System.Collections.Concurrent;
using System.Threading;

namespace laba8_2helpme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("привествуем вас на соревнованиях СОЧИ-2014!");

            BlockingCollection<Sportsmen> line = new BlockingCollection<Sportsmen>();

            Area[] sochi2014 = new Area[5];

            for (int i = 0; i < sochi2014.Length; i++)
            {
                sochi2014[i] = new Area(i + 1, line);
                new Thread(sochi2014[i].hard_work).Start();
            }

            for (int i = 0; i < 10; i++)
            {
                Sportsmen s = new Sportsmen(i + 1, line);
                new Thread(s.work).Start();
            }

            Thread.Sleep(15000);

            Console.WriteLine("соревнования СОЧИ-2014 объявляются закрытыми! (тёхтюыюф)");
            Console.ReadLine();
        }
    }
}
