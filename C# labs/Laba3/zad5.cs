namespace Laba3
{
    internal class Solution5
    {
        static Random rand = new Random();
        public static void main()
        {
            int M, N;
            Console.Write("Введите M: ");
            M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[M, N];


            Console.WriteLine("Ваша матрица:");
            for (int y = 0; y < M; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    matrix[y, x] = rand.Next(-100, 100);
                    //matrix[y, x] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int y = 0; y < M; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    Console.Write("{0,4} ", matrix[y, x]);
                }
                Console.WriteLine();
            }

            int term_row = 101;
            int term_col = 101;

            for (int i = 0; i < M; i++)
            {
                int min_in_row = matrix[i, 0];
                int col_of_min = 0;

                for (int j = 1; j < N; j++)
                {
                    if (matrix[i, j] < min_in_row)
                    {
                        min_in_row = matrix[i, j];
                        col_of_min = j;
                    }
                }

                bool sedlovaya = true;
                for (int k = 0; k < M; k++)
                {
                    if (matrix[k, col_of_min] > min_in_row)
                    {
                        sedlovaya = false;
                        break;
                    }
                }

                if (sedlovaya)
                {
                    term_row = i;
                    term_col = col_of_min;
                    break;
                }
            }

            if (term_row != 101 && term_col != 101)
            {
                Console.WriteLine($"седловая точка находится по координатам [{term_row}][{term_col}], ее  значение: {matrix[term_row, term_col]}");
            }
            else
            {
                Console.WriteLine("седловая точка не найдена");
                return;
            }

            Console.ReadLine();
        }
    }
}
