namespace Dodge
{
	using UnityEngine;

	public interface IGeneratable
	{
		void Generate(Transform prefab, Vector3 position);
		//void Remove();
	}
}

