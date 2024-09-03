namespace Laba3
{
    internal class Solution4
    {
        static Random rand = new Random();

        public static void main()
        {

            int M, N;

            Console.Write("введите M:");
            M = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите N:");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[M, N];


            Console.WriteLine("ваша матрица:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                int minq = matrix[i, 0];
                for (int j = 0; j < N; j++)
                {
                    if (minq > matrix[i, j])
                    {
                        minq = matrix[i, j];
                    }
                }
                Console.WriteLine($"min элемент в строке {i}: {minq} ");
                Console.WriteLine();
            }

            int min = 101;
            int max = -101;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"max элемент в матрице {max}: ");
            Console.WriteLine($"min элемент в матрице {min}: ");
            Console.WriteLine();

            int sum = 0;
            foreach (int item in matrix)
            {
                sum += item;
            }

            sum -= min + max;
            int avg = sum / M + N;

            Console.WriteLine($"среднее значение для всех: {avg}");

            Console.ReadLine();
        }
    }
}
