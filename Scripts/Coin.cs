namespace Dodge
{
	using UnityEngine;
	using System.Collections;
	
	public class Coin : MonoBehaviour 
	{
		private GameObject player;
		private GameObject coin;

		private bool coinPassed = false;

		private GenerateCoins generateCoinsScript;

		// Use this for initialization
		void Start () 
		{
			this.coin = this.gameObject;
			this.player = GameObject.Find ("Player");
		}
		
		// Update is called once per frame
		void Update ()
		{
			if (this.player.transform.position.z > this.coin.transform.position.z && !coinPassed) 
			{
				Destroy(this.gameObject, 0.3f);
				this.coinPassed = true;
				// Lower the count of coins on the map
				player.GetComponent<GenerateCoins>().CoinsCount--;

				Destroy(this.gameObject.transform.parent.gameObject,3f);
			}
		}

		void OnTriggerEnter(Collider obj)
		{
			if (obj.gameObject.tag == "Player")
			{
				// Destroy the coin if it collides with the player
				Destroy(this.gameObject);

				// Get the script attached to Main Player
				this.generateCoinsScript = obj.GetComponent<GenerateCoins>();

				// Modify variables of the Main Player script
				this.generateCoinsScript.CoinsCount--;
				this.generateCoinsScript.CoinsPicked++;

				// Destroy all coins and theirs parent gameObject if not picked
				Destroy(this.gameObject.transform.parent.gameObject,3f);
				Debug.Log (this.generateCoinsScript.CoinsPicked);
			}
		}
	}
}

