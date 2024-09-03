namespace Laba3
{
    internal class Solution8
    {
        static Random rnd = new Random();
        public static void main()
        {
            int[][][] array = new int[3][][];

            array[0] = new int[2][];
            array[1] = new int[3][];
            array[2] = new int[2][];

            array[0][0] = new int[2];
            array[0][1] = new int[2];

            array[1][0] = new int[2];
            array[1][1] = new int[2];
            array[1][2] = new int[2];

            array[2][0] = new int[3];
            array[2][1] = new int[3];



            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        array[i][j][k] = rnd.Next(-100, 100);
                    }
                }
            }

            Console.WriteLine("ваш массив матриц:" + Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"ваша {i + 1}-ая матрица:");
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        Console.Write(array[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int sum_of_min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    int min_str = 101;

                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        if (array[i][j][k] < min_str)
                        {
                            min_str = array[i][j][k];
                        }
                    }
                    sum_of_min += min_str;
                }
            }
            Console.WriteLine("сумма всех минамальных элементов по строчкам = " + sum_of_min);

            Console.ReadLine();
        }
    }
}