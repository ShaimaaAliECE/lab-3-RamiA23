using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int value;

        public Coin(string name, int score = 0, int value = 0) : base(name, score, value)
        {
            Description = name;
            this.value = value;
        }

        private void UpdateTotalValue()
        {
            CollectionBoard.TotValue = CollectionBoard.TotValue + value;
        }
        public override void Display()
        {
            Console.Write($"Coin {Description} is displayed\n");
        }
        public override void AddMe(List<Collectable> l)
        {
            UpdateTotalValue();
            base.AddMe(l);
        }
    }
}