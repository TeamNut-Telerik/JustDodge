namespace Assets.Scripts.Models
{
    using Assets.Scripts.Enumerations;

    public class Automobile : EnemyCar
    {
        public Automobile(EManufacturer manufacturer, float maxSpeed, float price, EColor color)
            : base(manufacturer, maxSpeed, price, color)
        {
        }
    }
}
