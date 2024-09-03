using System;

namespace Laba5_2lib
{
    /// <summary>
    /// Класс представляющий реализацию вычесления
    /// путём разложения на ряды Тейлора
    /// функции: Ln(x+1)
    /// </summary>
    public class MathTaylor
    {
        /// <summary>
        /// Точность вычислений
        /// </summary>
        public double eps = 1e-9;
        /// <summary>
        /// Количество иттераций последней вызванной функции Calculate
        /// (сомнительно)
        /// </summary>
        public int count;
        public MathTaylor() { }

        /// <summary>
        /// Функция для расчёта Ln(x+1)
        /// рекурентным способом
        /// </summary>
        /// <param name="x">Переменная X</param>
        /// <returns></returns>
        public double Calculate(double x)
        {

            double res = 0, a = -x;
            int n = 0;
            while (Math.Abs(a) > eps)
            {
                res += a;
                n++;
                a *= -(n * x) / (n + 1);
            }

            count = n;
            return res;
        }

    }
}
