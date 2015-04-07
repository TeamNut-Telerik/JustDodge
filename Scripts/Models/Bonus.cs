using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Models
{
    public abstract class Bonus:IBonus
    {
        private string name;
        private DateTime durationEnd;

        public DateTime DurationEnd
        {
            get { return this.durationEnd; }
            set { this.durationEnd = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
    }
}
