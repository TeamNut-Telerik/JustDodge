namespace Assets.Scripts.ScreenVisualisers
{
    using System;
    using UnityEngine;
    using Assets.Scripts.Common;

    public class StatsBar : MonoBehaviour
    {
        private int coins;
        private Level level;

        void Start()
        {
            var stats = Stats.LoadStats();
            this.coins = stats[0];
            this.level.Experience = stats[1];
        }

        void Update()
        {
            this.gameObject.GetComponent<TextMesh>().color = Color.blue;
            this.gameObject.GetComponent<TextMesh>().text =
                "Stats:" + Environment.NewLine + Environment.NewLine +
                "Coins : " + this.coins.ToString() + Environment.NewLine +
                "Experience : " + this.level.Experience.ToString() + Environment.NewLine +
                "Level : " + this.level.PlayerLevel.ToString();
        }
    }

}

