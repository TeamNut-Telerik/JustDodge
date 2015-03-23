namespace Dodge
{
	using UnityEngine;
	using System.Collections;
	using System;
	
	public class InfoBar : MonoBehaviour 
	{
		private GenerateCoins coinsScript;
		private Car carScript;
		
		// Use this for initialization
		void Start () 
		{
			this.coinsScript = GameObject.Find ("Player").GetComponent<GenerateCoins>();
			this.carScript = GameObject.Find ("Player").GetComponent<Car>();
		}
		
		// Update is called once per frame
		void Update ()
		{
			this.gameObject.GetComponent<TextMesh> ().color = Color.yellow;
			this.gameObject.GetComponent<TextMesh> ().text = 
				"Coins : " + this.coinsScript.CoinsPicked.ToString () +
				"            Score : " + ((int)this.carScript.Score).ToString () +
				"            Km/h : " + (Math.Floor(this.carScript.Speed * 100)).ToString ();

			if (this.carScript.CanDie == false) 
			{
				this.gameObject.GetComponent<TextMesh> ().text +=
					"            Undead : " + ((int)(this.carScript.MaximumTimeUndead - this.carScript.TimeUndead)).ToString ();
			}
		}
	}

}

