namespace Assets.Scripts.Models
{
    using Assets.Scripts.Enumerations;

    public class Ambulance : EnemyCar
    {
        public Ambulance(EManufacturer manufacturer, float maxSpeed, float price, EColor color)
            : base(manufacturer, maxSpeed, price, color)
        {
        }
    }
}
