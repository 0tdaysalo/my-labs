namespace laba7_2
{
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }
    }
}
