namespace Dodge
{
	using UnityEngine;
	using System.Collections;
	
	public class CameraFollow : MonoBehaviour
	{
		private const int DistanceFromCar = 6;

		public GameObject player;
		
		// Update is called once per frame
		void Update () 
		{
			this.gameObject.transform.position = new Vector3
				(this.gameObject.transform.position.x,
				 this.gameObject.transform.position.y,
				 player.gameObject.transform.position.z - DistanceFromCar);
		}
	}
}
