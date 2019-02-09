using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductDetails prod = new ProductDetails();

            prod.Details();
            prod.Edit();
            prod.LeafyGreensonly();
            prod.Garlic();
            prod.Cabbage();
            prod.Amount();
        }
    }
}
