using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> listOfBoxes = new List<Box>();
            
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] properties = input.Split().ToArray();

                string serialNumber = properties[0];
                string itemName = properties[1];
                int itemQty = int.Parse(properties[2]);
                decimal itemPrice = decimal.Parse(properties[3]);

              
                Box box = new Box(serialNumber, new Item(itemName, itemPrice), itemQty);

                listOfBoxes.Add(box);

                input = Console.ReadLine();
            }

            List<Box> orderedListOfBoxes = listOfBoxes.OrderByDescending(box => box.PriceForABox).ToList();

            foreach (var box in orderedListOfBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQty}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}

class Item
{
    public Item(string itemName, decimal itemPrice)
    {
        Name = itemName;
        Price = itemPrice;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    public Box(string serialNumber, Item item, int itemQty)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQty = itemQty;
    }
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQty { get; set; }
    public decimal PriceForABox 
    {
        get
        {
            return this.ItemQty * this.Item.Price;
        }
    }
}
