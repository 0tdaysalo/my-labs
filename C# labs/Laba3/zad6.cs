namespace Laba3
{
    internal class Solution6
    {
        public static void main()
        {
            // 3.6.2.Дана строка, содержащая пробелы. Найдите в ней самое длинное слово, выведите на экран это слово и его длину
            Console.Write("введите фразу:");

            string str = Console.ReadLine();
            string word = " ";

            str.Split(' ').ToList().ForEach(x =>
            {
                if (word.Length < x.Length)
                {
                    word = x;
                }
            });

            Console.WriteLine($"ваша фраза: {str}, самое длинное слово среди них: {word} его длина {word.Length} символов");


            Console.ReadLine();
        }
    }
}