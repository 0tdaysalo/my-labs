namespace Laba3
{
    internal class Solution2
    {
        public static void main()
        {
            //Выполнить обмен соседними ячейками массива (элементы с индексами 0 и 1, 2 и 3 и т.д.;
            //если число ячеек нечётное, то значение последней ячейки массива не меняется).

            Console.Write("введите количество элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("заполните массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"введите {i}-ый элемент массива:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ваш массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i += 2)
            {
                if (i == n - 1)
                {
                    break;
                }
                int term;
                term = array[i + 1];
                array[i + 1] = array[i];
                array[i] = term;

            }

            Console.WriteLine("ваш измененный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
