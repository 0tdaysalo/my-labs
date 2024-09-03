namespace Laba6_2
{
    public class Product
    {
        string name;
        string number;
        string count;
        string price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Count
        {
            get { return count; }
            set { count = value; }
        }

        public Product(string name, string number, string count, string price)
        {
            Name = name;
            Number = number;
            Count = count;
            Price = price;
        }

    }
}
