namespace laba8_3
{
    internal class Solution1
    {
        public static void main()
        {
            Func<ulong, bool> perf_number = n =>
            {
                ulong sum = 0;
                for (ulong i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum == n;
            };

            Console.WriteLine("введите число:");
            ulong num = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("совершенные числа до {0}:", num);
            for (ulong i = 2; i <= num; i++)
            {
                if (perf_number(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
