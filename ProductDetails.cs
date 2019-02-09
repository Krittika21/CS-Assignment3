using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory
{
    public class ProductDetails
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public double price;

        public List<ProductDetails> Products = new List<ProductDetails>();
        public void Details()
        {
            Products.Add(new ProductDetails() { Name = "Lettuce", Cost = 10.5, Quantity = 50, Type = "Leafy Greens" });
            Products.Add(new ProductDetails() { Name = "Cabbage", Cost = 20, Quantity = 100, Type = "Cruciferous" });
            Products.Add(new ProductDetails() { Name = "Pumpkin", Cost = 30, Quantity = 30, Type = "Marrow" });
            Products.Add(new ProductDetails() { Name = "Cauliflower", Cost = 10, Quantity = 25, Type = "Cruciferous" });
            Products.Add(new ProductDetails() { Name = "Zucchini", Cost = 20.5, Quantity = 50, Type = "Marrow" });
            Products.Add(new ProductDetails() { Name = "Yam", Cost = 30, Quantity = 50, Type = "Root" });
            Products.Add(new ProductDetails() { Name = "Spinach", Cost = 10, Quantity = 100, Type = "Leafy Greens" });
            Products.Add(new ProductDetails() { Name = "Broccoli", Cost = 20.2, Quantity = 75, Type = "Cruciferous" });
            Products.Add(new ProductDetails() { Name = "Garlic", Cost = 30, Quantity = 20, Type = "Leafy Greens" });
            Products.Add(new ProductDetails() { Name = "Silverbeet", Cost = 10, Quantity = 50, Type = "Marrow" });

            Console.WriteLine($"The total no of items present in the inventory : {Products.Count}");
        }
        public void Edit()
        {
            //Add
            Products.Add(new ProductDetails() { Name = "Potato", Cost = 10, Quantity = 50, Type = "Root" });
            Console.WriteLine("After adding Potato to the list;");
            //Count
            Console.WriteLine($"The new no of items present in the inventory : {Products.Count}");

            //Printing the updatted list
            Console.WriteLine("\nAll the products:\n");
            foreach (var product in Products)
            {
                Console.WriteLine(product.Name + "  " + "Rs" + product.Cost + "  " + product.Quantity + "  " + product.Type);
            }
        }
        //printing only the leafy greens
        public void LeafyGreensonly()
        {
            Console.WriteLine("\nAll the Leafy Greens are:\n");
            foreach (var product in Products)
            {
                if (product.Type == "Leafy Greens")
                {
                    Console.WriteLine(product.Name + " " + product.Cost + " " + product.Quantity + " " + product.Type);
                }
            }
        }
        //Removing Garlic
        public void Garlic()
        {

            for (int i = 0; i <= Products.Count - 1; i++)
            {
                if (Products[i].Name.Contains("Garlic"))
                {
                    Products.RemoveAt(i);
                }
            }

            Console.WriteLine($"\nAfter removing Garlic no of items left in the inventory : {Products.Count}\nAnd the remaining products are:\n");
            foreach (var product in Products)
            {
                Console.WriteLine(product.Name + "  " + "Rs" + product.Cost + "  " + product.Quantity + "  " + product.Type);
            }
        }
        public void Cabbage()
        {
            for (int i = 0; i <= Products.Count - 1; i++)
            {
                if (Products[i].Name.Contains("cabbage"))
                {
                    Products[i].Quantity += 50;
                    Console.WriteLine("The final quantity of cabbage is :" + Products[i].Quantity);
                }
            }
        }
        public void Amount()
        {
            foreach (var product in Products)
            {
                if(product.Name == "Lettuce")
                {
                    price += product.Cost / product.Quantity;
                }
                if (product.Name == "Zucchini")
                {
                    price += product.Cost / product.Quantity;
                }
                if (product.Name == "Broccoli")
                {
                    price += product.Cost / product.Quantity;
                }
            }
            Console.WriteLine("\nTotal amount to be paid for 1kg lettuce, 2 kg zucchini, 1 kg broccoli is :\t" + price );


        }
    }
}
