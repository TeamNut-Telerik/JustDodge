using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public abstract class Bonus:IBonus
    {
        private string name;
        private DateTime duration;

        public DateTime Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
    }
}
