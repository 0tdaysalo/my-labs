namespace Laba3
{
    internal class Solution3
    {
        public static void main()
        {

            Console.WriteLine("введите количество элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            int[] array_numbers = new int[9];

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

            for (int i = 0; i < n; i++)
            {
                array_numbers[array[i] - 1] += 1;
            }

            Console.WriteLine("количество единиц, двоек, ... , девяток в вашем массиве:");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(array_numbers[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

