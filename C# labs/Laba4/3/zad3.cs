using Laba4._3;
namespace Laba4zad3
{
    internal class Solution3
    {
        public static void main()
        {
            string[] file_in = File.ReadAllLines("in.txt");
            //чтение файла и фулл запись в file_in по массивам строк 

            int count_student = Convert.ToInt32(file_in[0]) + 1;
            //запись количества строк студентов

            Student[] array_of_students = new Student[count_student];

            double max_avg_mark = 1;
            string surname = "";
            string name = "";

            for (int i = 1; i < count_student; i++)
            {
                string[] s = file_in[i].Split(' ');
                array_of_students[i] = new Student(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4]));
                surname = array_of_students[i].surname;
                name = array_of_students[i].name;
                if (max_avg_mark < array_of_students[i].get_avg())
                {
                    max_avg_mark = array_of_students[i].get_avg();

                }
                Console.WriteLine("че " + surname + name + max_avg_mark);
            }
            Console.WriteLine();
            Console.WriteLine("норм типчик " + surname + name + max_avg_mark);

            //StreamWriter file_out = new StreamWriter("out.txt");

            string file_path = "C:\\Users\\pavel\\Desktop\\labi proga 2 semak\\Labi\\Laba4\\bin\\Debug\\net8.0";
            FileStream file_out = File.Open(file_path, FileMode.OpenOrCreate);

            //file_out.Write("qq");

            //НЕ РАБОТАЕТ

            //file_out.Write(surname);
            //file_out.Write(name);
            //file_out.Write(max_avg_mark);

        }
    }
}
