namespace Dodge
{
	using UnityEngine;
	using System.Collections;
    using Assets.Scripts;
    using Assets.Scripts.Enumerations;

	
	public class EnemyCar : Vehicle
	{
		private int sizeOfPlayerCar;
		private bool regulateCarsCount = true;

		private float minimalSpeed;
		private float maximumSpeed;
		private float speed;

		GenerateEnemyCars script; 
		private GameObject car;
		private GameObject player;

		private Material randomMaterial;

		public float Speed 
		{
			get {return this.speed;}
			set {this.speed = value;}
		}

        public EnemyCar(EManufacturer manufacturer, float maxSpeed, float price, EColor color):
            base(manufacturer,maxSpeed,price,color)
        {

        }
		// Use this for initialization
		void Start () 
		{
			this.car = this.gameObject;
			this.player = GameObject.Find ("Player");
			this.script = this.player.GetComponent<GenerateEnemyCars> ();
			this.sizeOfPlayerCar = 6;
			this.minimalSpeed = 0.3f;
			this.maximumSpeed = 0.7f;
			this.Speed = Random.Range(this.minimalSpeed, this.maximumSpeed);

			//this.randomMaterial = new Material (Shader.Find ("Standard"));
			//this.randomMaterial.color = new Color(Random.Range (0,255),Random.Range (0,255),Random.Range (0,255),1);
			//this.gameObject.GetComponent<MeshRenderer> ().material = randomMaterial;
			//this.gameObject.GetComponentInChildren<MeshRenderer> ().material.color = Color.blue;
		}
		
		// Update is called once per frame
		void Update () 
		{
			Move (this.car);
			DestroyCar ();

		}

		void OnTriggerEnter(Collider col)
		{
			if (col.gameObject.tag == "EnemyCar") 
			{
				var script = col.GetComponent<EnemyCar> ();
				script.Speed = this.Speed;
			}
		}

		void DestroyCar()
		{
			if (this.player.transform.position.z > this.car.transform.position.z + this.sizeOfPlayerCar) 
			{
				Destroy (this.car);
				
				while (this.regulateCarsCount == true)
				{
					this.script.CarsCount--;
					this.regulateCarsCount = false;
				}
			}
		}
		
		void Move(GameObject car)
		{
			this.car.transform.position = new Vector3
				(this.car.transform.position.x,
				 this.car.transform.position.y,
				 this.car.transform.position.z + this.speed);
		}
	}

}