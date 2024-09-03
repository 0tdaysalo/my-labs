namespace laba7_2
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string position, int salary) : base(name)
        {
            Position = position;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working as a {Position}.");
        }
    }
}
