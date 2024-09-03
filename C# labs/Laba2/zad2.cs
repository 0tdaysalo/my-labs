namespace Laba2
{
    internal class Solution2
    {
        static int my_pow(int a, int n)//рекурсивная функция (сама себя вызывает)
        {
            if (n == 2)
            {
                return a * a;
            }
            return a * my_pow(a, n);
        }

        static void main()
        {
            int a;
            Console.Write("введите a");
            a = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.Write("введите n");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"a^n = {my_pow(a, n)}");
            Console.ReadLine();
        }
    }
}
