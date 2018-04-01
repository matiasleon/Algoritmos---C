using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace LootMaxValue
{
    class MaxValueOfLoot
    {
        static void Main(string[] args)
        {
            var numberItemsCapacity = Console.ReadLine();
            var split = numberItemsCapacity.Split(' ');
            var itemsCount = int.Parse(split[0]);
            var capacity = int.Parse(split[1]);
            var orderedElements = CreateItems(itemsCount).OrderByDescending(x => x.ValueWeigth).ToList();

            // obtengo la minima cantidad q puedo meter 
            var totalValue = Decimal.Zero;            
            while (orderedElements.Count() != 0 && capacity > 0 )
            {
                // obtengo la cantidad minima que puedo seteear
                var minCount = 0;
                var orderedElement = orderedElements.First();
                if (orderedElement.ActualWeight <= capacity)
                {
                    minCount = orderedElement.Weigth;
                    orderedElements.Remove(orderedElement);
                }
                else
                {
                    minCount = capacity;
                    orderedElement.ActualWeight = orderedElement.ActualWeight - minCount;
                }
                //obtener la cantidad minima
                capacity = capacity - minCount;
                totalValue = totalValue + minCount * orderedElement.ValueWeigth;
            }

            Console.WriteLine(Math.Round(totalValue,4));
            Console.ReadLine();
        }

        private static IList<Item> CreateItems(int itemsCount)
        {
            var items = new List<Item>();
            for (int i = 0; i < itemsCount; i++)
            {
                var valueWeigthInput = Console.ReadLine();
                var valueWeight = valueWeigthInput.Split(' ');
                var value = int.Parse(valueWeight[0]);
                var weigth = int.Parse(valueWeight[1]);
                var item = new Item(value, weigth);
                items.Add(item);
            }

            return items;
        }

        public class Item
        {
            public decimal Value { get; set; }

            public int Weigth { get; set; }

            public int ActualWeight { get; set; }

            public decimal ValueWeigth
            {
                get { return this.Value / this.Weigth; }
            }

            public Item(decimal value, int weigth)
            {
                this.Value = value;
                this.Weigth = weigth;
                this.ActualWeight = Weigth;
            }
        }
    }
}
