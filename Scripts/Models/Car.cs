namespace Assets.Scripts.Models
{
    using System.Collections;

    using Assets.Scripts;
    using Assets.Scripts.Enumerations;
    using Assets.Scripts.Generatables;
    using Assets.Scripts.Common;
    using Assets.Interfaces;
    using UnityEngine;

	public class Car : Vehicle , ICar
	{
		// This variable declares how much distance will the car move left or right
		private static float MoveLengthByX = 5.5f;
		private const float acceleration = 0.02f;

		// This variable helps us move the car properly so it doesnt get out of the road
		private int PositionOnRoad = 1;

        private GameObject player;

		// This variable will keep the score
		private int score;

		// The speed with which the car moves
	    public float Speed { get; set; }

        private int[] stats;

        private Level level;

		//These variables will be used for the bonuses we take

		private bool canDie;  // Undead bonus
		private float timeUndead;
		private float maximumTimeUndead;

		public float minSpeed {get; set;}
		public float maxSpeed {get; set;}
		public int Score
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
            this.level = new Level();
            this.stats = Stats.LoadStats();
            this.Position = gameObject.transform.position;
            this.PositionOnRoad = 1;
			this.minSpeed = 0.5f;
			this.maxSpeed = 1.3f;
            this.Speed = this.minSpeed;
			this.Score = 0;
			this.canDie = true;
			this.timeUndead = 0;
			this.maximumTimeUndead = 7f;
            this.player = this.gameObject;
            this.level.Experience = stats[2];
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
                    this.timeUndead = 0;
					this.canDie = true;
				}
			}

			this.Score += (int)(this.Speed * 2 * this.level.PlayerLevel);
            this.level.Experience = this.Score;

			this.gameObject.transform.position = this.Position;
		}

		//Check for all collisions possible
		void OnTriggerEnter(Collider col)
		{
			if (col.gameObject.tag == "EnemyCar" && this.canDie) 
			{
                Stats.SaveStats(this.player.GetComponent<GenerateCoins>().CoinsPicked + this.stats[0], this.level.Experience + this.stats[1]);
				Application.LoadLevel(0);
			}
			else if(col.gameObject.tag == "EnemyCar" && !this.canDie)
			{
				Destroy (col.gameObject);
                this.gameObject.GetComponent<GenerateEnemyCars>().CarsCount--;
                this.Score += 300;
			}
			else if(col.gameObject.tag == "UndeadBonus")
			{
				this.canDie = false;
			}
		}

	    public void MoveForward()
	    {
			this.Position = new Vector3 (this.Position.x, this.Position.y, this.Position.z + this.Speed);
	    }

		public void MoveLeft()
		{
			if (this.PositionOnRoad > 0) 
			{
                this.Position = new Vector3(this.Position.x - MoveLengthByX, this.Position.y, this.Position.z);
                this.PositionOnRoad--;
			}
            else if (this.PositionOnRoad < 0)
            {
                throw new OutOfRoadException("Car cannot go out of road!");
            }
        }

        public void MoveRight()
		{
			if (this.PositionOnRoad < 2) 
			{
				this.Position = new Vector3 (this.Position.x + MoveLengthByX, this.Position.y, this.Position.z);
				this.PositionOnRoad++;
			}

		}
	}
}