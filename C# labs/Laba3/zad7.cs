using System.Text;

namespace Laba3
{
    internal class Solution7
    {
        static Random rand = new Random();
        public static void main()
        {
            //3.7.2.Составить строку длины l, заполненную случайными символами: от “j ” до “r ”, цифрами от 0 до 5 и знаками «?», «!» и «;». Заменить все вхождения символа «!» на «_»

            Console.Write("введите l:");
            int l = Convert.ToInt32(Console.ReadLine());

            string alph = "jklmnopqr012345?!;";

            StringBuilder str = new(l);

            for (int i = 0; i < l; i++)
            {
                str.Append(alph[rand.Next(alph.Length)]);
            }
            Console.WriteLine("ваша фраза: " + str);

            str.Replace(';', '_');

            Console.WriteLine($"ваша изменённая строка: {str}");


            Console.ReadLine();
        }
    }
}