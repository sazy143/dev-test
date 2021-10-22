using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        private const int Days = 20;

        public static void Main(string[] args)
        {
            IList<Item> Items2 = new List<Item>{
                new Item {Name = "Bananas", SellIn = 2, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 50},
                new Item {Name = "Eggs", SellIn = 2, Quality = 7},
                new Item {Name = "Eggs", SellIn = 12, Quality = 5},
                new Item {Name = "Canned Beans", SellIn = 0, Quality = 80},
                new Item {Name = "Canned Beans", SellIn = -1, Quality = 80},
                
                // This Baked good does not work properly yet!
                new Item {Name = "Baked Sourdough Bread", SellIn = 3, Quality = 6},
                new Item {Name = "Baked Beans", SellIn = 2, Quality = 40 }
            };

            var app2 = new GildedRose(Items2);

            for (var i = 0; i < (Days + 1); i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items2.Count; j++)
                {
                    System.Console.WriteLine(Items2[j].Name + ", " + Items2[j].SellIn + ", " + Items2[j].Quality);
                }
                Console.WriteLine("");
                app2.UpdateQualityNew();
            }
            Console.ReadKey();
        }
    }
}
