using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Assets.Scripts.Enumerations;

namespace Assets.Scripts.Models
{
    public class Bus : EnemyCar
    {
        public Bus(EManufacturer manufacturer, float maxSpeed, float price, EColor color) :
            base(manufacturer, maxSpeed, price, color)
        {
        }
    }
}
