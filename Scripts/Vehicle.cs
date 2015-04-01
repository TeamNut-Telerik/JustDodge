using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dodge;
using Assets.Scripts.Enumerations;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Vehicle : MonoBehaviour, IVehicle
    {
        #region FIELDS
        private EManufacturer manufacturer;
        private float maxSpeed;
        private float price;
        private EColor color;
        #endregion

        #region CONSTRUCTORS
        public Vehicle(EManufacturer manufacturer, float maxSpeed, float price, EColor color)
        {
            this.manufacturer = manufacturer;
            this.MaxSpeed = maxSpeed;
            this.Price = price;
            this.color = color;
        }
        #endregion

        #region PROPERTIES
        public EManufacturer Manufacturer
        {
            get { return this.manufacturer; }
            private set { this.manufacturer = value; }
        }

        public float MaxSpeed 
        {
            get { return this.maxSpeed; }
            private set
            {
                if (value < 10 || value > 400)
                {
                    throw new ArgumentException("Max speed should be between 10-400!");
                }
                this.maxSpeed = value;
            }
        }

        public float Price
        {
            get { return this.price; }
            private set
            {
                if (value < 500)
                {
                    throw new ArgumentException("Min price should be more than 500!");
                }
                this.maxSpeed = value;
            }
        }

        public EColor Color
        {
            get { return this.color; }
            private set { this.color = value; }
        }

        public UnityEngine.Vector3 Position { get; set; }

        #endregion

        #region METHODS
        //  virtual because EnemyCar does not have these methods
        public virtual void MoveForward()
        {

        }

        public virtual void MoveLeft()
        {

        }

        public virtual void MoveRight() 
        {
        }
        #endregion
    }
}
