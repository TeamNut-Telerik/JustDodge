namespace Assets.Interfaces
{
	using UnityEngine;

	public interface ICar
	{
		float Speed {get;}
		Vector3 Position { get; }

		void MoveForward();
		void MoveLeft();
		void MoveRight();
	}
}

