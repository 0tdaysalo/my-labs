using System;
using System.Collections.Concurrent;
namespace laba8_2helpme
{
    public class Sportsmen
    {
        public string Name;
        public string Sport;
        public BlockingCollection<Sportsmen> line_of_sportsmen;

        public Sportsmen(int n, BlockingCollection<Sportsmen> line)
        {
            var rnd = new Random();
            line_of_sportsmen = line;
            Name = "sportsmen" + n.ToString();

            string[] Sport_type =
            {
                "downhill_skiing",
                "biathlon",
                "bobsleigh",
                "figure_skating",
                "curling",
                "snowboarding",
                "ice_hockey",
                "luge"
            };
            Sport = Sport_type[rnd.Next(Sport_type.Length)];
        }

        public void work()
        {
            line_of_sportsmen.Add(this);
        }
    }
}
