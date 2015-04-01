
namespace Dodge
{
	using UnityEngine;

	public class GenerateEnemyCars : MonoBehaviour,  IGeneratable
	{
		private const float MoveLengthByX = 6.0f;
		private const float midLaneX = -0.5f;

		private int carsCount;
		private int distanceBetweenCars;

		private GameObject player;
		private GameObject enemyCar;

		private Transform carTransform;
		private EnemyCar car;

		public Transform prefab;

		public int CarsCount
		{
			get {return this.carsCount;}
			set {this.carsCount = value;}
		}

		void Start()
		{
			this.player = this.gameObject;
			this.carsCount = 0;
			this.distanceBetweenCars = 15;
		}

		void Update()
		{
			if (this.carsCount < 6)
			{
				Generate (this.prefab, new Vector3 
				          (midLaneX + Random.Range(-1,2) * MoveLengthByX,
				 		  this.player.transform.position.y,
				 		  this.transform.position.z + distanceBetweenCars * (carsCount+1) ));
				this.carsCount++;
			}
		}

		public void Generate(Transform prefab, Vector3 position)
		{
			this.carTransform = (Transform)Instantiate(prefab, position, Quaternion.identity);
			this.enemyCar = this.carTransform.gameObject;
			this.car = this.enemyCar.AddComponent<EnemyCar> ();
		}

	}
}

