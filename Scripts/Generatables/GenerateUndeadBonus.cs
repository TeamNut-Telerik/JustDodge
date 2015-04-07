namespace Assets.Scripts.Generatables
{
    using UnityEngine;
    using System.Collections;
    using Assets.Interfaces;
    using Assets.Scripts.Models;

    public class GenerateUndeadBonus : GenerateBonus
    {
        private int bonusCount = 0;
        public override float MidLaneX
        {
            get { return -3f; }
        }

        public override float MoveLengthByX
        {
            get { return 5f; }
        }

        public int BonusCount
        {
            get
            {
                return this.bonusCount;
            }
            set
            {
                this.bonusCount = value;
            }
        }

        public Transform undeadBonusPrefab;
        private Transform undeadTransform;

        //public int CoinsCount
        //{
        //    get { return this.coinsCount; }
        //    set { this.coinsCount = value; }
        //}

        //public int CoinsPicked
        //{
        //    get { return this.coinsPicked; }
        //    set { this.coinsPicked = value; }
        //}


        // Use this for initialization
        public override void Start()
        {
            base.player = this.gameObject;
            //this.CoinsCount = 0;
            //this.CoinsPicked = 0;
        }

        //Update is called once per frame
        public override void Update()
        {
            if (this.bonusCount < 3)
            {
                Generate(this.undeadBonusPrefab, new Vector3
                        (MidLaneX+ Random.Range(-1, 2) * MoveLengthByX,
                        this.player.transform.position.y + 0.25f,
                        this.player.transform.position.z + Random.Range(10, 1050)));
                this.bonusCount++;
            }
            
            
            //if (this.player.transform.position.z > this.gameObject.transform.position.z + 10)
            //{
            //    Destroy(this.gameObject);
            //}
        }

        public override void Generate(Transform prefab, Vector3 position)
        {
            this.undeadTransform = (Transform)Instantiate(prefab, position, Quaternion.identity);
            this.undeadTransform.gameObject.AddComponent<UndeadBonus>();

        }
    }
}
