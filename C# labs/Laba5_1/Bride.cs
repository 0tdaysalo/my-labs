namespace laba5_1
{
    internal class Bride
    {
        public WomanProperties wish_properties = 0;
        public ManProperties properties;
        public string surname = "";

        internal Bride(string surname)
        {
            this.surname = surname;
        }

        public List<Groom> rateGrooms(List<Groom> mens)
        {
            List<Groom> rate_1 = new List<Groom>();
            List<Groom> rate_2 = new List<Groom>();
            List<Groom> rate_3 = new List<Groom>();
            List<Groom> rate_4 = new List<Groom>();

            mens.ForEach(emp =>
            {
                // Добавляем те которые полностью соответсвуют требованиям
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
            });
            rate_3.AddRange(rate_4);
            rate_2.AddRange(rate_3);
            rate_1.AddRange(rate_2);
            return rate_1;

        }
    }
}
