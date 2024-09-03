namespace laba5_1
{
    internal class Groom
    {
        public WomanProperties properties = 0;
        public ManProperties wish_properties = 0;
        public string surname = "";

        public Groom(string surname)
        {
            this.surname = surname;
        }

        public List<Bride> rateBride(List<Bride> mens)
        {
            List<Bride> rate_1 = new List<Bride>();
            List<Bride> rate_2 = new List<Bride>();
            List<Bride> rate_3 = new List<Bride>();
            List<Bride> rate_4 = new List<Bride>();

            mens.ForEach(emp =>
            {
                if (((emp.properties & wish_properties) == wish_properties) && ((emp.properties & ~wish_properties) == 0))
                {
                    rate_1.Add(emp);
                    return;
                }
                if ((emp.properties & wish_properties) == wish_properties)
                {
                    rate_2.Add(emp);
                    return;
                }
                if ((emp.properties & wish_properties) > 0)
                {
                    rate_3.Add(emp);
                    return;
                }
                rate_4.Add(emp);
            }); // если полностью соответсвуют требованиям то добавляем

            rate_3.AddRange(rate_4);
            rate_2.AddRange(rate_3);
            rate_1.AddRange(rate_2);

            return rate_1;
        }
    }
}
