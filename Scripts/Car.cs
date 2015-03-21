namespace Dodge
{
	using UnityEngine;
	using System.Collections;

	public class Car : MonoBehaviour , ICar
	{
		// This variable declares how much distance will the car move left or right
		private const float MoveLengthByX = 6.0f;

		// This variable helps us move the car properly so it doesnt get out of the road
		// For example : It starts at 1 because it is in the middle lane. 
		// It is equal to 0 if it goes to left lane and it is equal to 2 when it goes to right lane
		private int PositionOnRoad = 1;

		// The speed with which the car moves
	    public float Speed { get; set; }

		// The position we will set to the car
	    public Vector3 Position { get; set; }


		// Use this like it is the constructor of the class
		void Start () 
	    {
			this.Position = gameObject.transform.position;
			this.Speed = 0.5f;
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

			gameObject.transform.position = this.Position;

		}

	    public void MoveForward()
	    {
			this.Position = new Vector3 (this.Position.x, this.Position.y, this.Position.z + this.Speed);
	    }

		public void MoveLeft()
		{
			if (this.PositionOnRoad > 0) 
			{
				this.Position = new Vector3 (this.Position.x - MoveLengthByX, this.Position.y, this.Position.z);
				this.PositionOnRoad--;
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