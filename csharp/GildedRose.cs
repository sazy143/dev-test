using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQualityNew()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                int baseDecay = 1;

                switch (Items[i].Name) {
                    case "Canned Beans":
                        break;
                    case string s when s.StartsWith("Baked"):
                        if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = decay(Items[i].Quality, baseDecay * 2);
                        }
                        else
                        {
                            Items[i].Quality = expiredDecay(Items[i].Quality, baseDecay * 2);
                        }
                        break;
                    case "Aged Brie":
                        if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = decay(Items[i].Quality, baseDecay * -1);
                        }
                        else
                        {
                            Items[i].Quality = expiredDecay(Items[i].Quality, baseDecay * -1);
                        }
                        break;
                    default:
                        if (Items[i].SellIn > 0)
                        {
                            Items[i].Quality = decay(Items[i].Quality, baseDecay);
                        }
                        else
                        {
                            Items[i].Quality = expiredDecay(Items[i].Quality, baseDecay);
                        }
                        break;
                }
                
                Items[i].SellIn -= 1;
            }
        }

        private static int decay(int itemValue, int decayValue) {
            int value = itemValue;
            if (itemValue >= 0 && itemValue <= 50)
            {
                value = itemValue - decayValue;
            }
            if (value < 0)
                value = 0;
            if (value > 50)
                value = 50;
            return value;
        }
        private static int expiredDecay(int itemValue, int decayValue) {
            int value = itemValue;
            if (itemValue >= 0 && itemValue <= 50)
            {
                value = itemValue - (decayValue * 2);
            }
            if (value < 0)
                value = 0;
            if (value > 50)
                value = 50;
            return value;
        }
    }
}
