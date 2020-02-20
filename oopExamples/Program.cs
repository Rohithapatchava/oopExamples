using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1,"chocolate",20);
            category cat = new category(2, "sweet", product);
            cat.display();
        }
    }
}
