namespace laba6_3
{
    internal class Solution1
    {
        static void Main(string[] args)
        {
            string file_class_txt = File.ReadAllText("person.cs");
            Console.WriteLine("весь файл:\n");


            Console.WriteLine(file_class_txt);

            string[] stroki = file_class_txt.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);

            List<string> list_metodov = new List<string>();

            for (int i = 0; i < stroki.Length; i++)
            {
                //for(int e = 0; e<100;e++ )
                //{
                //    string str1 = "";
                //    str1.PadLeft(e);
                //    string str2 = str1+"//";
                //    if (stroki[i].EndsWith(")") && stroki[i].StartsWith(str2) == false)
                //    {

                //    }                   
                //}
                if (
                    stroki[i].EndsWith(")") &&
                    stroki[i].StartsWith("//") == false &&
                    stroki[i].StartsWith(" //") == false &&
                    stroki[i].StartsWith("  //") == false &&
                    stroki[i].StartsWith("   //") == false &&
                    stroki[i].StartsWith("    //") == false &&
                    stroki[i].StartsWith("     //") == false &&
                    stroki[i].StartsWith("      //") == false &&
                    stroki[i].StartsWith("       //") == false &&
                    stroki[i].StartsWith("        //") == false &&
                    stroki[i].StartsWith("         //") == false &&
                    stroki[i].StartsWith("          //") == false &&
                    stroki[i].StartsWith("           //") == false
                    //укоротить бы 
                    )
                {
                    Console.WriteLine("\nв файле найден метод(ы):");

                    bool check = true;
                    for (int j = i; j < stroki.Length; j++)
                    {
                        if (check != false)
                        {
                            Console.WriteLine(stroki[j]);
                            list_metodov.Add(stroki[j]);
                        }

                        for (int k = 0; k < 100; k++)
                        {
                            string str3 = "";
                            str3.PadLeft(k);
                            string str4 = str3 + "}";

                            if (k == 0)
                            {
                                if (stroki[j] == "}")
                                {
                                    check = false;
                                }
                            }
                            else if (stroki[j] == str4)
                            {
                                check = false;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\nproverka, vse workkk:");
            for (int i = 0; i < list_metodov.Count; i++)
            {
                Console.WriteLine(list_metodov[i]);
            }

            //всё сломалось
            Console.ReadLine();
        }
    }
}
