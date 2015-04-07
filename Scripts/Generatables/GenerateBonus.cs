namespace Assets.Scripts.Generatables
{
    using UnityEngine;
    using System.Collections;
    using Assets.Interfaces;

    public abstract class GenerateBonus : MonoBehaviour, IGeneratable
    {
        private const float midLaneX = 0.6f;
        private const float moveLengthByX = 5f;

        public abstract float MidLaneX { get; }
        public abstract float MoveLengthByX { get; }

        protected GameObject player;

        // Use this for initialization
        public virtual void Start()
        {
            this.player = this.gameObject;
        }

        // Update is called once per frame
        public virtual void Update()
        {
        }

        public abstract void Generate(Transform prefab, Vector3 position);
    }
}
