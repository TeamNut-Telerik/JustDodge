namespace Dodge
{
	using UnityEngine;

	public interface ICar
	{
        string Manufacturer { get; }
        string Color { get; }
        float MaxSpeed { get; }
        float Price { get;  }
		Vector3 Position { get; }

		void MoveForward();
		void MoveLeft();
		void MoveRight();
	}
}

