using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class category
    {
        int cid;
        string description;
        Product product;
        public category(int cid,string description,Product product)
        {
            this.cid = cid;
            this.description = description;
        }
        public void display()
        {
            Console.WriteLine(cid+" "+description+" "+product.pid+" "+product.name+" "+product.price);
        }
    }
}
