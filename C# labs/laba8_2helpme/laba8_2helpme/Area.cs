using System;
using System.Collections.Concurrent;
using System.Threading;
namespace laba8_2helpme
{
    public class Area
    {
        public string Name;
        public bool work_unwork;
        public BlockingCollection<Sportsmen> line_of_sportsmen;
        public Random rnd = new Random();
        public Area(int n, BlockingCollection<Sportsmen> line)
        {
            line_of_sportsmen = line;
            if (n <= 5)
            {
                Name = "Area" + n.ToString();
            }
            else
            {
                throw new Exception("количество площадок может быть максимум 5");
            }
        }

        public void hard_work()
        {
            while (true)
            {
                if (line_of_sportsmen.TryTake(out var sportsmen))
                {
                    Console.WriteLine($"на площадку {this.Name} зашёл спортсмен {sportsmen.Name} и соревнуется в виде спорта: {sportsmen.Sport}");
                    Thread.Sleep(rnd.Next(1000, 2000));
                    if (rnd.Next(0, 100) < 50)
                    {
                        Console.WriteLine($"на площадке {this.Name} спортсмен {sportsmen.Name} проиграл в виде спорта: {sportsmen.Sport}");
                        line_of_sportsmen.Add(sportsmen);
                    }
                    else
                    {
                        Console.WriteLine($"на площадке {this.Name} спортсмен {sportsmen.Name} выиграл в виде спорта: {sportsmen.Sport}");
                    }
                }
            }
        }
    }
}
