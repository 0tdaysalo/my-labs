using Laba4zad1._1;

namespace Laba4zad1
{
    internal class Solution1
    {
        public static void main()
        {
            Time vtornik = new Time(13, 59, 59);
            Console.WriteLine($"установлено время: {vtornik.ToString()}");

            Console.WriteLine("установка времени 00:00:00 с помощью функций set_hours, set_minutes, set_seconds");
            vtornik.set_hours(0);
            vtornik.set_minutes(0);
            vtornik.set_seconds(0);
            Console.WriteLine(vtornik);

            Console.WriteLine("Добавление 140 часов: ");
            vtornik.add_time(140, 0, 0);
            Console.WriteLine(vtornik.ToString());

            Console.WriteLine("Добавление 140 минут: ");
            vtornik.add_time(0, 140, 0);
            Console.WriteLine(vtornik.ToString());

            Console.WriteLine("Добавление 140 секунд: ");
            vtornik.add_time(0, 0, 140);
            Console.WriteLine(vtornik.ToString());



            Console.WriteLine("Вычитание 10 часов: ");
            vtornik.add_time(-10, 0, 0);
            Console.WriteLine(vtornik.ToString());

            Console.WriteLine("Вычитание 10 минут: ");
            vtornik.add_time(0, -10, 0);
            Console.WriteLine(vtornik.ToString());

            Console.WriteLine("Вычитание 10 секунд: ");
            vtornik.add_time(0, 0, -10);
            Console.WriteLine(vtornik.ToString());
        }
    }
}

