using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        private int score;

        public Treasure(String name, int score = 0, int value = 0) : base(name, score, value)
        {
            Description = name;
            this.score = score;
        }

        private void UpdateTotalScore()
        {
            CollectionBoard.TotScore = CollectionBoard.TotScore + score;
            Console.WriteLine($"Total Score is updated to: {CollectionBoard.TotScore}");
        }
        public override void AddMe(List<Collectable> l)
        {
            base.AddMe(l);
            UpdateTotalScore();
        }
    }
}
