using System;
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

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                int changeRate = ChangeRate.changeRate(Items[i]);
                if (Items[i].SellIn <= 0)
                {
                    changeRate *= 2;
                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        Items[i].Quality = 0;
                    }
                }
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].Quality = Math.Max(0, Math.Min(50, Items[i].Quality + changeRate));
                    Items[i].SellIn = Items[i].SellIn - 1;
                }
            }
        }
    }
}



