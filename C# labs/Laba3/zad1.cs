namespace Laba3
{
    internal class Solution1
    {
        static Random rnd = new Random();
        static int func_count_not_neg(int[] array, int n)
        {
            int count_not_neg = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    count_not_neg++;
                }
            }
            return count_not_neg;
        }

        static int func_sum_not_neg(int[] array, int n)
        {
            int sum_not_neg = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    sum_not_neg += array[i];
                }
            }
            return sum_not_neg;
        }

        static int func_find_min_neg(int[] array, int n)
        {
            int min_neg_index = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < array[min_neg_index])
                {
                    min_neg_index = i;
                }
            }
            return min_neg_index;
        }

        static void good_print(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}] = {array[i]}");

            }
        }


        public static void main()
        {
            int n = 15;
            int[] array = new int[n];

            Console.Write("автоматическое заполнение массива:\n");

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }

            Console.Write("ваш массив:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write("\n");

            int count = func_count_not_neg(array, n);

            Console.Write("количество неотрицательных чисел: " + count + "\n");
            int sum = func_sum_not_neg(array, n);

            Console.Write("сумма отрицательных чисел: " + sum + "\n");
            int find = func_find_min_neg(array, n);

            Console.Write("номер с минимальным числом: " + find + "\n");
            good_print(array, n);

            Console.ReadLine();
        }
    }
}
