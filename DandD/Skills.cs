using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DandD
{
    public class Skill
    {
        public Skill(Ability parentStat, bool trainedOnly):this(parentStat)
        {
            this.TrainedOnly = trainedOnly;
        }
        public Skill(Ability parentStat)
        {
            this.ParentStat = parentStat;
        }
        private Ability ParentStat { get; set; }
        public bool IsFavored { get; set; }
        public int Ranks { get; set; }
        private int IsFavoredModifier
        {
            get
            {
                if (!IsFavored) { return 0; }
                if (Ranks <= 0) { return 0; }
                return 3;
            }
        }
        public bool TrainedOnly { get; set; }
        public int RollModifier {
            get {
                if (this.TrainedOnly){ return 0; }
                return Ranks + ParentStat.Modifier + IsFavoredModifier;
            }

        }
    }
}
        