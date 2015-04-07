namespace Assets
{
	using UnityEngine;
    using Assets.Scripts.Enumerations;

	public interface IVehicle
	{
        EManufacturer Manufacturer { get; }
        EColor Color { get; }
        float MaxSpeed { get; }
        float Price { get;  }
		Vector3 Position { get; }
	}
}

