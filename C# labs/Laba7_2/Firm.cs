namespace laba7_2
{
    public class Firm
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public Firm(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }
    }
}
