using System.Reflection;

namespace laba7_2
{
    internal class CodeRunner
    {
        public static void Main(string[] args)
        {
            Type[] points = FindEntryPoints();
            int sel = 0;
            ConsoleKey s = ConsoleKey.A;
            do
            {
                if (s == ConsoleKey.UpArrow)
                {
                    sel = (sel - 1 < 0) ? points.Length - 1 : sel - 1;
                }
                else if (s == ConsoleKey.DownArrow)
                {
                    sel = (sel + 1 >= points.Length) ? 0 : sel + 1;
                }
                Console.Clear();
                Console.WriteLine(" Select programm: \n");
                for (int i = 0; i < points.Length; i++)
                {
                    Console.WriteLine("[" + (i == sel ? "*" : " ") + "] " + points[i].Name);
                }
            } while ((s = Console.ReadKey().Key) != ConsoleKey.Enter);
            Console.Clear();
            RunMain(points[sel]);
        }

        public static void RunMain(Type type)
        {
            MethodInfo? f = type.GetMethod("main");
            f.Invoke(null, null);
        }

        public static Type[] FindEntryPoints()
        {
            Assembly ass = Assembly.GetCallingAssembly();
            return ass.GetTypes().Where((c) => c.GetMethod("main") != null).ToArray();
        }
    }
}