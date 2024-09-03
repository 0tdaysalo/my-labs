using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba6_2
{
    public class Store : IEnumerable
    {
        List<Product> entries = new List<Product>();

        /// <summary>
        /// Создаёт обхект Notebook с определённым количеством записей
        /// </summary>
        /// <param name="n">Количество записей</param>
        public Store(int n)
        {
            entries = new List<Product>(n);
        }

        /// <summary>
        /// Создаёт объект Notebook
        /// </summary>
        public Store() { }

        IEnumerator IEnumerable.GetEnumerator() { return entries.GetEnumerator(); }

        public void Add(Product product)
        {
            entries.Add(product);
        }

        public List<Product> SearchByNumber(string number)
        {
            return entries.Where((en) => en.Number.Contains(number)).ToList();
        }

        public List<Product> SearchByName(string name)
        {
            return entries.Where((en) => en.Name.Contains(name)).ToList();
        }
    }
}
