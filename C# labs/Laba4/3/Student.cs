namespace Laba4._3
{
    internal class Student
    {
        public string surname;
        public string name;
        public int mark_math;
        public int mark_phiz;
        public int mark_inf;

        public Student(string surname, string name, int mark_math, int mark_phiz, int mark_inf)
        {
            this.surname = surname;
            this.name = name;
            this.mark_math = mark_math;
            this.mark_phiz = mark_phiz;
            this.mark_inf = mark_inf;
        }

        public double get_avg()
        {
            return (this.mark_math + this.mark_phiz + mark_inf) / 3.0d;
        }

        //int max_avg = 0;
        //for (int i = 1; i < count_student; i++)
        //{
        //    string[] s = file_in[i].Split(' ');
        //    array_of_students[i] = new Student(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4]));
        //    int avg_mark = (array_of_students[i].mark_phiz + array_of_students[i].mark_math + array_of_students[i].mark_inf) / 3;
        //    string surname_max_avg = array_of_students[i].surname;
        //    string name_max_avg = array_of_students[i].name;
        //    if (avg_mark > max_avg)
        //    {
        //        avg_mark = max_avg;

        //    }
        //}
    }
}
