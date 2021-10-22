﻿using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Canned Beans")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].Name == "Aged Brie")
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
                else
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Canned Beans")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name == "Aged Brie")
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != "Canned Beans")
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
