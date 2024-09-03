namespace Laba1
{
    internal class Solution1
    {
        public static void main()
        {

            double y, x, d, b, z;
            Console.Write("введите переменную x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("введите переменную d: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.Write("введите переменную b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("введите переменную z: ");
            z = Convert.ToDouble(Console.ReadLine());

            // 11*13 стандарт 
            // 1*7 деление
            // 4*5 умножение
            // 3*3 вычитание 
            // 1*3 сложение
            // 1 присваивание 
            //183 итого
            if (
                (((Math.Sin(2 * Math.Exp(Math.Pow(d, 3)) + Math.Log10(b))) -
                (Math.Sin(2 * Math.Exp(Math.Pow(d, 3)) - Math.Log10(b)))) != 0)
                && (z > 0) && (b > 0)
                )
            {
                y = (4 * Math.Pow(Math.Cos(x * Math.Log(z)), 2) - 2) / (
                    (Math.Sin(2 * Math.Exp(Math.Pow(d, 3)) + Math.Log10(b)))
                    - (Math.Sin(2 * Math.Exp(Math.Pow(d, 3)) - Math.Log10(b))));

                Console.Write("это y: " + y + " 183 у.е\n");



                //происходит упрощение
                //можно сделать замену
                double q, r, s;

                q = Math.Log10(b); //14

                r = 2 * Math.Exp(Math.Pow(d, 3)); //29
                s = Math.Cos(x * Math.Log(z)); //29

                y = (4 * s * s - 2) / ((Math.Sin(r + q) - (Math.Sin(r - q))));
                // 3*5 + 3 + 3 + 13*2 + 3
                Console.Write("это такой же y: " + y + " но 122 у.е");

            }
            else
            {
                Console.Write("введёные данные не принадлежает ООФ!");
            }

            Console.ReadLine();
        }
    }
}
