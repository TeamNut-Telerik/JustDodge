namespace Dodge
{
	using UnityEngine;
	using System.Collections;
	using System;

	public class GenerateBasicArea : MonoBehaviour , IGeneratable
	{
		private const float firstBasicAreaX = 8f;
		private const float firstBasicAreaY = 0.44f;
		private const float firstBasicAreaZ = 32f;
		private const float areaAvailabilityTime = 25f;

		private GameObject area;
		private GameObject player;
		private int basicAreaLength;
		private int BasicAreasCount;

		public Transform basicAreaPrefab;

		// Use this for initialization
		void Start () 
		{
			this.BasicAreasCount = 0;
			this.player = this.gameObject;
			this.basicAreaLength = 161;

			Destroy (GameObject.Find ("FirstBasicArea"),20);
		}
		
		// Update is called once per frame
		void Update () 
		{
			Generate (this.basicAreaPrefab, new Vector3(firstBasicAreaX , firstBasicAreaY, (firstBasicAreaZ + basicAreaLength * (this.BasicAreasCount + 1))) );
		}

		 public void Generate(Transform prefab, Vector3 position)
		 {
			if (this.player.transform.position.z > this.basicAreaLength * this.BasicAreasCount) 
			{
				this.area = (GameObject)Instantiate(basicAreaPrefab, position, Quaternion.identity);
				Destroy (this.area, areaAvailabilityTime);
				this.BasicAreasCount++;
			}
		 }
	}
}
