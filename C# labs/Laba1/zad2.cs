namespace Laba1
{
    internal class Solution2
    {
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void main()
        {

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
                Console.Write($"{array[i]} ");
            }

            int low = 0;
            int mid = 0;
            int high = array.Length - 1;


            while (mid <= high)
            {
                switch (array[mid])
                {
                    case 0:
                        int temp = array[low];
                        array[low] = array[mid];
                        array[mid] = temp;
                        low++;
                        mid++;
                        break;

                    case 1:
                        mid++;
                        break;

                    case 2:
                        temp = array[mid];
                        array[mid] = array[high];
                        array[high] = temp;
                        high--;
                        break;

                }
            }

            //aлгоритм состоит из трех переменных: low, mid и high.мы начинаем с того, что устанавливаем low и mid в ноль, а high в последний индекс массива(в данном случае, 5).
            //затем мы используем цикл, который будет выполняться, пока mid не превысит high. внутри цикла мы проверяем текущий элемент массива array[mid]:
            //-если он равен 0, то мы перемещаем его в начало массива, на позицию low, и увеличиваем значения low и mid на единицу. таким образом, мы передвигаем все нули в начало массива.
            //-если он равен 1, то мы просто увеличиваем значение mid на единицу, так как единицы должны остаться между нулями и двойками.
            //-если он равен 2, то мы перемещаем его в конец массива, на позицию high, и уменьшаем значение high на единицу. таким образом, мы передвигаем все двойки в конец массива.

            Console.WriteLine("\nваш отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadLine();
        }
    }
}