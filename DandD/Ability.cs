using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DandD
{
    public class Ability
    {
        public Ability()
        {

        }
        public Ability(int score)
        {
            this.Score = score;
        }
        public int Score { get; set; }
        public int Modifier {
            get
            {
                return (Score - (Score % 2) - 10) / 2;
            }
        }
    }
}