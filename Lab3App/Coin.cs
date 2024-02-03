using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int Value;

        public Coin(string name, int score = 0, int value = 0) : base(name, score, value)
        {
            Description = name;
            this.Value = value;
        }

        private void UpdateTotValue()
        {
            CollectionBoard.TotValue = CollectionBoard.TotValue + Value;
            Console.WriteLine($"Total Value is updated to: {CollectionBoard.TotValue}");
        }
        public override void Display()
        {
            Console.Write($"Coin {Description} is displayed\n");
        }
        public override void AddMe(List<Collectable> l)
        {
            base.AddMe(l);
            UpdateTotValue();
        }
    }
}