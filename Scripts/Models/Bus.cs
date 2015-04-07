namespace Assets.Scripts.Models
{
    using Assets.Scripts.Enumerations;
    
    public class Bus : EnemyCar
    {
        public Bus(EManufacturer manufacturer, float maxSpeed, float price, EColor color)
            : base(manufacturer, maxSpeed, price, color)
        {
        }
    }
}
