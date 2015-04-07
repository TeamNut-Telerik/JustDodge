namespace Assets.Scripts.Generatables
{
    using Assets.Interfaces;
    using Assets.Scripts.Models;
    using UnityEngine;

	public class GenerateEnemyCars : MonoBehaviour,  IGeneratable
	{
		private const float MoveLengthByX = 5.5f;
		private const float midLaneX = -0.5f;

		private int carsCount;
		private int distanceBetweenCars;

		private GameObject player;
		private GameObject enemyCar;

		private Transform carTransform;

		public Transform prefab;
        public Transform prefabBus;
        public Transform prefabAmbulance;

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
                int random = Random.Range(0, 13);

                if(random <= 5)
                {
                    Generate(this.prefabBus, new Vector3
                          ((midLaneX - 0.3f) + Random.Range(-1, 2) * MoveLengthByX,
                          this.player.transform.position.y - 0.8f,
                          this.transform.position.z + distanceBetweenCars * (carsCount + 1)));
                    this.carsCount++;
                }
                else if(random > 5 && random <= 10 )
                {
                    Generate(this.prefab, new Vector3
                          ((midLaneX - 0.2f) + Random.Range(-1, 2) * MoveLengthByX,
                          this.player.transform.position.y + 0.2f,
                          this.transform.position.z + distanceBetweenCars * (carsCount + 1)));
                    this.carsCount++;
                }
                else
                {
                    Generate(this.prefabAmbulance, new Vector3
                          ((midLaneX - 0.2f) + Random.Range(-1, 2) * MoveLengthByX,
                          this.player.transform.position.y + 0.6f,
                          this.transform.position.z + distanceBetweenCars * (carsCount + 1)));
                    this.carsCount++;
                }
			}
		}

		public void Generate(Transform prefab, Vector3 position)
		{
			this.carTransform = (Transform)Instantiate(prefab, position, Quaternion.identity);
			this.enemyCar = this.carTransform.gameObject;
            if (this.prefab == prefabBus)
            {
                this.enemyCar.AddComponent<Bus>();
            }
            else if (this.prefab == prefabAmbulance)
            {
                this.enemyCar.AddComponent<Ambulance>();
            }
            else
            {
                this.enemyCar.AddComponent<Automobile>();
            }
		}

	}
}

