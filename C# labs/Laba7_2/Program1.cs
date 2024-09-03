namespace laba7_2
{
    internal class Solution1
    {
        public static void main()
        {
            //есть иерархия классов, начиная с абстрактного класса Person,
            //затем классы Employee и Boss, далее класс Department и класс Firm,
            //которые наследуют и вкладываются друг в друга для моделирования структуры компании.
            //Классы представляют собой различные уровни иерархии в предприятии,
            //от индивидуальных сотрудников до всей фирмы.

            //Person worker_samokat1 = new Person("seva");
            //worker_samokat1.Name = "seva";

            Employee employer1 = new Employee("pasha", "direktor", 60000);
            Console.WriteLine(employer1.Position);

            Boss boss1 = new Boss("stepa", "glava progi", 999999999, "psuti");
            Console.WriteLine(boss1.Department);

            Department depart = new Department("psuti");
            depart.Employees.Add(employer1);
            Console.WriteLine(depart.Employees);

            Firm firm = new Firm("ministerstvo obr");
            firm.Departments.Add(depart);
            Console.WriteLine(firm.Departments);

        }
    }
}
