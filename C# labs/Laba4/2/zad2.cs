using System.Text;

namespace test
{
    internal class Solution2
    {
        public static Random rnd = new Random();

        public static string random_surname()
        {
            StringBuilder str = new StringBuilder();

            str.Append((char)rnd.Next('\u0410', '\u0429'));
            char[] alph_gl = new char[] { 'у', 'е', 'о', 'ы', 'а', 'я', 'и', 'ю' };
            char[] alph_sogl = new char[] { 'й', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п', 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б' };
            int length = rnd.Next(4, 10);

            for (int i = 1; i < length; i++)
            {
                if (i == length - 1)
                {
                    str.Append(alph_sogl[rnd.Next(alph_sogl.Length)]);
                }
                else if (i % 2 == 0)
                {
                    str.Append(alph_sogl[rnd.Next(alph_sogl.Length)]);
                }
                else
                {
                    str.Append(alph_gl[rnd.Next(alph_gl.Length)]);
                }
            }

            switch (rnd.Next(1, 11))
            {
                case 1:
                    str.Append("ов");
                    break;
                case 2:
                    str.Append("ев");
                    break;
                case 3:
                    str.Append("ко");
                    break;
                case 4:
                    str.Append("ин");
                    break;
                case 5:
                    str.Append("ова");
                    break;
                case 6:
                    str.Append("ева");
                    break;
                case 7:
                    str.Append("ина");
                    break;
                case 8:
                    str.Append("ая");
                    break;
                case 9:
                    str.Append("их");
                    break;
            }

            return str.ToString(); ;
        }
        static Book[] GetBooks(int n)
        {
            Book[] books = new Book[n];
            for (int i = 0; i < n; i++)
            {
                books[i] = new Book(random_surname(), (Book_type)rnd.Next(0, 5));
            }

            return books.OrderBy((book) => book.surname).ToArray();
        }

        public static void main()
        {
            Book kniga = new Book(random_surname(), Book_type.FICTION);

            Console.WriteLine("книга от автора: {0} имеет тип {1}", kniga.surname, kniga.theme);

            Console.WriteLine("введите количество книг, которые вы хотите создать:");
            int count_books = Convert.ToInt32(Console.ReadLine());
            var KNIGI = GetBooks(count_books);

            for (int i = 0; i < KNIGI.Length; i++)
            {
                Console.WriteLine("книга от автора: {0} имеет тип {1}", KNIGI[i].surname, KNIGI[i].theme);
            }


            Console.WriteLine("введите количество наборов:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix_books = new int[n, (count_books / n) + 3];//на всякий случай

            //KNIGI = KNIGI.OrderBy((book) => book.theme).ToArray();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (count_books / n) + 3; j++)
                {
                    matrix_books[i, j] = (int)KNIGI[j].theme;
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (count_books / n) + 1; j++)
                {
                    Console.WriteLine("ну и круто братан:" + matrix_books[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
