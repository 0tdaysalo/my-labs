using System.Collections;

namespace Laba8_1
{
    partial class Form1
    {
        private void replace_space(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string item = (string)list[i];
                list[i] = item.Replace(" ", "_");
            }
        }

        private void replace_slash(ArrayList list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                string item = (string)list[i];
                list[i] = item.Replace("/", "\\");
            }
        }

        private void replace_back_slash(ArrayList list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                string item = (string)list[i];
                list[i] = item.Replace("/", "//");
            }
        }

        private void to_upp(ArrayList list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                string item = (string)list[i];
                list[i] = item.ToUpper();
            }
        }
    }
}
