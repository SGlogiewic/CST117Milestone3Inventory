using System;

namespace CST117Milestone3Inventory
{
    class InventoryMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Garden Supply Shop Inventory:");
            Console.WriteLine(" ");

            InventoryManager IM = new InventoryManager();

            //Make products to add
            Product p = new Product();
            p.name = "Ferns";
            p.prodID = "1";
            p.price = 12;
            p.category = "Live Plants";
            p.stockQnty = 0;
            Product p2 = new Product();
            p2.name = "Spade";
            p2.prodID = "2";
            p2.price = 7;
            p2.category = "Gardening Tools";
            p2.stockQnty = 5;
            Product p3 = new Product();
            p3.name = "Spring Seeds";
            p3.prodID = "3";
            p3.price = 2;
            p3.category = "Seeds";
            p3.stockQnty = 2;
            Product p4 = new Product();
            p4.name = "Soil";
            p4.prodID = "4";
            p4.price = 13;
            p4.category = "Fertilizers";
            p4.stockQnty = 2;
            Product p5 = new Product();
            p5.name = "Mulch";
            p5.prodID = "5";
            p5.price = 20;
            p5.category = "Fertilizers";
            p5.stockQnty = 5;

            //Add them to Inventory Manager
            Console.WriteLine("Adding items to inventory...");
            IM.addItem(p);
            IM.addItem(p2);
            IM.addItem(p3);
            IM.addItem(p4);
            IM.addItem(p5);

            //Display Inventory Manager
            IM.displayItems();

            //Restocking Ferns item
            Console.WriteLine("\nRestocking " + p.name);
            IM.restockItem(5, p);
            IM.displayItems();

            //Remove item from Inventory Manager
            Console.WriteLine("\nRemoving " + p.name + " from inventory...");
            IM.removeItem(p);
            IM.displayItems();



            //Searching for items by ID, category, and price
            Console.WriteLine("\nSearching for item by ID...");
            Product target = IM.findByID("5");
            if (target == null)
            {
                Console.WriteLine("Item with that ID not found.");
            }
            else
            {
                Console.WriteLine("Found " + target);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Searching for item by category...");
            Product target2 = IM.findByCategory("Seeds");
            if (target == null)
            {
                Console.WriteLine("Item of that type not found.");
            }
            else
            {
                Console.WriteLine("Found  " + target2);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Searching for item by price...");
            Product target3 = IM.findByPrice(20);
            if (target == null)
            {
                Console.WriteLine("Item with that price not found.");
            }
            else
            {
                Console.WriteLine("Found " + target3);
            }
        }
    }
    class Product
    {
        public string name { set; get; }
        public string prodID { set; get; }
        public double price { set; get; }
        public string category { set; get; }
        public int stockQnty { set; get; }


        public Product()
        {
            name = "";
            prodID = "";
            price = 0;
            category = "";
            stockQnty = 0;
        }
        public override string ToString()
        {
            return "Item Name: " + name + ", Product ID: " + prodID + ", Price: $" + price + ", Category: " + category
                + ", Stock Quantity: " + stockQnty;
        }
    }
}
