using System;
using System.Collections.Generic;

namespace Restaurant
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        public List<string> Category { get; set; }
        public DateTime DateAdded {get; set; }

        public MenuItem(string name,int itemId, double price, string description,List<String>category, DateTime added )
        {
            this.Name = name;
            this.ItemId = itemId;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.DateAdded = added;

        }
    }

    class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }
        public int MenuId { get; set; }

        public Menu(string name, DateTime updated, List<MenuItem> items, int menuId)
        {
            this.Items = items;
            this.LastUpdated = updated;
            this.Name = name;
            this.MenuId = menuId;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            MenuItem pasta = new MenuItem("Chicken Alfredo",
                12,
                13.99,
                "Creamy Deliciousness", 
                new List<string> { "entree", "dinner" }, 
                new DateTime());

            MenuItem gooeyButter = new MenuItem("Gooey Butter Cake",
                6,
                6.89,
                "Very Yummy",
                new List<string> { "dessert" },
                new DateTime());

            Menu resMenu = new Menu("The Place",
                new DateTime(),
                new List<MenuItem>() { pasta, gooeyButter },
                6);

            Console.WriteLine("Restaurant Name: " + resMenu.Name);

            Console.WriteLine(gooeyButter.Name + " " + gooeyButter.Price);

            resMenu.Items[1].Price = 12.14;

            Console.WriteLine(gooeyButter.Name + " " + gooeyButter.Price);
            Console.WriteLine(resMenu.Items[1].Name + " " + resMenu.Items[1].Price);

                
        }
    }
   
       
        
    
}
