namespace Laba2
{
    internal class Solution1
    {
        public static void main()
        {

            Console.Write("введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int multiplier = 1;

            while (n > 0)
            {
                int digit = n % 10;
                if (digit == 0)
                {
                    result += digit * multiplier;
                }
                else
                {
                    result += (10 - digit) * multiplier;
                }

                n /= 10;
                multiplier *= 10;
            }

            Console.WriteLine($"ваше UpToTen число: {result}");

            Console.Read();
        }
    }
}
