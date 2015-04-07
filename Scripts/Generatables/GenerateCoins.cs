namespace Assets.Scripts.Generatables
{
	using UnityEngine;
	using System.Collections;
    using Assets.Interfaces;
	
	public class GenerateCoins : MonoBehaviour , IGeneratable
	{
		private const float midLaneX = 0.9f;
		private const float MoveLengthByX = 6f;

		private int coinsPicked;
		private int coinsCount;

		private GameObject player;

		public Transform coinsPrefab;

		public int CoinsCount
		{
			get {return this.coinsCount;}
			set {this.coinsCount = value;}
		}

		public int CoinsPicked
		{
			get {return this.coinsPicked;}
			set {this.coinsPicked = value;}
		}

		// Use this for initialization
		void Start () 
		{
			this.player = this.gameObject;
			this.CoinsCount = 0;
			this.CoinsPicked = 0;
		}
		
		// Update is called once per frame
		void Update ()
		{
			if (this.coinsCount < 18) 
			{
				Generate (coinsPrefab, new Vector3
				         (midLaneX + Random.Range(-1,2) * MoveLengthByX,
				 		  this.player.transform.position.y,
				 		  this.player.transform.position.z + Random.Range(75,450)));

				this.coinsCount += 6;
			}
			if (this.player.transform.position.z > this.gameObject.transform.position.z + 10)
			{
				Destroy(this.gameObject);
			}
		}

		public void Generate(Transform prefab, Vector3 position)
		{
			//this.coinsTransform = (Transform)   coinsTransform is field of type Transform
            Instantiate (prefab, position, Quaternion.identity);
		}
	}
}
