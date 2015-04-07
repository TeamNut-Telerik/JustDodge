namespace Assets.Scripts.Models
{
    using UnityEngine;
	using System.Collections.Generic;
    using Assets.Scripts.Generatables;

    public class UndeadBonus : MonoBehaviour
    {
        private GameObject player;
        private GameObject bonus;

        private bool bonusPassed = false;

        private GenerateUndeadBonus generateBonusScript;

        // Use this for initialization
        void Start()
        {
            this.bonus = this.gameObject;
            this.player = GameObject.Find("Player");
        }

        // Update is called once per frame
        void Update()
        {
            if (this.player.transform.position.z > this.bonus.transform.position.z && !bonusPassed)
            {
                //Destroy(this.gameObject, 0.3f);
                this.bonusPassed = true;
                // Lower the count of coins on the map
                //Destroy(this.gameObject.transform.parent.gameObject, 3f);
            }
        }

        void OnTriggerEnter(Collider obj)
        {
            if (obj.gameObject.tag == "Player")
            {
                // Destroy the coin if it collides with the player
                //Destroy(this.gameObject);

                // Get the script attached to Main Player
                this.generateBonusScript = obj.GetComponent<GenerateUndeadBonus>();

                // Modify variables of the Main Player script
                this.generateBonusScript.BonusCount--;

                //Destroy all coins and theirs parent gameObject if not picked
                //Destroy(this.gameObject.transform.parent.gameObject, 3f);
            }
        }
    }
}
