namespace Assets.Scripts.Common
{
    public class Upgrades
    {
        public int MaximumSpeedLevel { get; set; }
        public int MaximumSpeedUpgradeCost { get; set; }

        public int CoinsPerSecondLevel { get; set; }

        public int CoinsPerSecondUpgradeCost { get; set; }

        // Get values from a text file
        public Upgrades()
        {

        }
    }
}
