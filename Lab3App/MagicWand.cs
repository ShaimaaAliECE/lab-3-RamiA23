using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(string name, int score = 0, int value = 0) : base(name, score, value)
        {
            Description = name;
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }
        public override void Display()
        {
            Console.Write($"MagicWand {Description} is displayed\n");
        }
        public override void AddMe(List<Collectable> l)
        {
            base.AddMe(l);
        }
    }
}
