namespace Dodge
{
	using UnityEngine;
	using System.Collections;
    using Assets.Scripts;
    using Assets.Scripts.Enumerations;

	public class Car : Vehicle
	{

		//Animations for the car
		public AnimationClip MoveCarLeft;


		// This variable declares how much distance will the car move left or right
		private static float MoveLengthByX = 6.0f;
		private const float acceleration = 0.02f;

		// This variable helps us move the car properly so it doesnt get out of the road
		private int PositionOnRoad = 1;

		// This variable will keep the score
		private float score;

		// This is the car we move
		private GameObject playerCar;

		// The speed with which the car moves
	    public float Speed { get; set; }

		//These variables will be used for the bonuses we take

		private bool canDie;  // Undead bonus
		private float timeUndead;
		private float maximumTimeUndead;

		// The position we will set to the car
	    public Vector3 Position { get; set; }

		public float minSpeed {get; set;}
		public float maxSpeed {get; set;}

		public float Score
		{
			get {return this.score;}
			set {this.score = value;}
		}

		public bool CanDie
		{
			get {return this.canDie;}
			set {this.canDie = value;}
		}

		public float TimeUndead
		{
			get {return this.timeUndead;}
			set {this.timeUndead = value;}
		}

		public float MaximumTimeUndead
		{
			get {return this.maximumTimeUndead;}
			set {this.maximumTimeUndead = value;}
		}

        public Car(EManufacturer manufacturer, float maxSpeed, float price, EColor color):
            base(manufacturer,maxSpeed,price,color)
        {

        }
		// Use this like it is the constructor of the class
		void Start () 
	    {
            this.Position = gameObject.transform.position;
            this.PositionOnRoad = 1;
			this.minSpeed = 0.5f;
			this.Speed = this.minSpeed;
			this.maxSpeed = 1.3f;
			this.playerCar = this.gameObject;
			this.Score = 0;
			this.canDie = true;
			this.timeUndead = 0;
			this.maximumTimeUndead = 7f;
		}

		// Update is called once per frame
		void Update () 
	    {
			this.MoveForward ();

			if (Input.GetKeyDown(KeyCode.LeftArrow)) 
			{
				this.MoveLeft();
			}
			if (Input.GetKeyDown(KeyCode.RightArrow)) 
			{
				this.MoveRight();
			}
			if (Input.GetKey(KeyCode.UpArrow)) 
			{
				if (this.Speed < this.maxSpeed)
				{
					this.Speed += acceleration;
				}
			}
			if (Input.GetKey(KeyCode.DownArrow)) 
			{
				if (this.Speed > this.minSpeed)
				{
					this.Speed -= acceleration*2;
				}
			}

			if (this.Speed < this.minSpeed) 
			{
				this.Speed = this.minSpeed;
			}
			if (this.canDie == false)
			{
				this.timeUndead += Time.deltaTime;
				if (this.timeUndead > this.maximumTimeUndead) 
				{
					this.canDie = true;
				}
			}

			this.Score += this.Speed;

			this.gameObject.transform.position = this.Position;
		}

		//Check for all collisions possible
		void OnTriggerEnter(Collider col)
		{
			if (col.gameObject.tag == "EnemyCar" && this.canDie) 
			{
				Application.LoadLevel(Application.loadedLevel);
			}
			else if(col.gameObject.tag == "EnemyCar" && !this.canDie)
			{
				Destroy (col);
			}
			else if(col.gameObject.tag == "UndeadBonus")
			{
				this.canDie = false;
			}
		}


	    public override void MoveForward()
	    {
			this.Position = new Vector3 (this.Position.x, this.Position.y, this.Position.z + this.Speed);
	    }

		public override void MoveLeft()
		{
			if (this.PositionOnRoad > 0) 
			{
				this.Position = new Vector3 (this.Position.x - MoveLengthByX, this.Position.y, this.Position.z);
				this.PositionOnRoad--;
			}
        }

        public override void MoveRight()
		{
			if (this.PositionOnRoad < 2) 
			{
				this.Position = new Vector3 (this.Position.x + MoveLengthByX, this.Position.y, this.Position.z);
				this.PositionOnRoad++;
			}

		}
	}
}