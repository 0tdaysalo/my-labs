using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laba6_2
{
    public partial class lab6_2_2 : Form
    {
        public Store store = new Store();
        public Random rnd = new Random();

        public lab6_2_2()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                Product product = GenerateProduct();
                store.Add(product);
            }
            UpdateTable();
        }

        public Product GenerateProduct()
        {

            string[] store_products =
            {
                "Apple", "Banana", "Watermelon", "Tomato", "Orange",
                "Pineapple", "Strawberry", "Blueberry", "Raspberry", "Blackberry", "Avocado",
                "Pear", "Peach", "Apricot", "Mango", "Lemon", "Lime", "Grapefruit", "Kiwi",
                "Coconut", "Cherry", "Fig", "Plum", "Papaya", "Pomegranate", "Guava", "Cantaloupe",
                "Honeydew", "Grapes", "Tangerine", "Cucumber", "Carrot", "Potato", "Onion", "Garlic",
                "Ginger", "Broccoli", "Cauliflower", "Cabbage", "Lettuce", "Spinach", "Kale",
                "Swiss_chard", "Asparagus", "Brussels_sprouts", "Bell_pepper", "Green_bean", "Zucchini", "Squash", "Eggplant",
                "Radish", "Celery", "Mushroom", "Tomato_paste", "Tomato_sauce", "Tomato_soup", "Fruit_juice",
                "Lemonade", "Orange_juice", "Apple_juice", "Coconut_water", "Almond_milk", "Soy_milk", "Oat_milk",
                "Rice_milk", "Yogurt", "Greek_yogurt", "Cottage_cheese", "Cream_cheese", "Cheddar_cheese",
                "Parmesan_cheese", "Mozzarella_cheese", "Butter", "Margarine", "Olive_oil",
                "Coconut_oil", "Canola_oil", "Vegetable_oil", "Peanut_butter", "Almond_butter",
                "Cashew_butter", "Hazelnut_butter", "Sunflower_seed_butter", "Chocolate_spread",
                "Jam", "Honey", "Maple_syrup", "Agave_nectar", "Stevia", "Sugar", "Brown_sugar",
                "Powdered_sugar", "Molasses", "Flour", "Whole_wheat_flour", "Almond_flour",
                "Coconut_flour", "Cornmeal", "Breadcrumbs", "Yeast"
            };
            string name = store_products[rnd.Next(store_products.Length)].ToString();


            string count = rnd.Next(0, 100).ToString();



            string number = rnd.Next(1000000, 9999999).ToString();


            string price = rnd.Next(5, 1000).ToString();

            return new Product(name, number, count, price);
        }
        public void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            foreach (Product ent in store)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.SetValues(ent.Name, ent.Count, ent.Number, ent.Price);
                dataGridView1.Rows.Add(row);
            }
        }
        public void UpdateTable(List<Product> lst)
        {
            dataGridView1.Rows.Clear();
            foreach (var ent in lst)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.SetValues(ent.Name, ent.Count, ent.Number, ent.Price);
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> founded = store.SearchByNumber(numberTextBox.Text);
            if (founded.Count == 0)
            {
                MessageBox.Show(this, "не найдено", "-");
            }
            UpdateTable(founded);
            numberTextBox.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Product> founded = store.SearchByName(textBox1.Text);
            if (founded.Count == 0)
            {
                MessageBox.Show(this, "не найдено", "-");
            }
            UpdateTable(founded);
            textBox1.Clear();
        }
    }
}
