namespace Assets.Interfaces
{
	using UnityEngine;

	public interface IGeneratable
	{
		void Generate(Transform prefab, Vector3 position);
	}
}

