namespace laba7_2
{
    public class Boss : Employee
    {
        public string Department { get; set; }

        public Boss(string name, string position, int salary, string department) : base(name, position, salary)
        {
            Department = department;
        }

        public void Manage()
        {
            Console.WriteLine($"{Name} is managing the {Department} department.");
        }
    }
}
