using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Assets.Scripts.Enumerations;

namespace Assets.Scripts.Models
{
    public class Ambulance : EnemyCar
    {
        public Ambulance(EManufacturer manufacturer, float maxSpeed, float price, EColor color) :
            base(manufacturer, maxSpeed, price, color)
        {
        }
    }
}
