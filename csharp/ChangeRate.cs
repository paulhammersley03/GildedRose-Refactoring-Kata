using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ChangeRate
    {
        public static int changeRate(Item item)
        {
            switch(item.Name)
            {
                default:
                    return -1;
                case "Aged Brie":
                    return 1;
                case "Sulfuras, Hand of Ragnaros":
                    return 0;
                case "Conjured Mana Cake":
                    return -2;
                case "Backstage passes to a TAFKAL80ETC concert":
                    if (item.SellIn <= 0)
                        return 0;
                    if (item.SellIn <= 5)
                        return 3;
                    if(item.SellIn <= 10)
                        return 2;
                    if(item.SellIn > 10)
                        return 1;
                    return 0;
            }
        }
    }
}
