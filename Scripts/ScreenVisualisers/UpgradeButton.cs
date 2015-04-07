namespace Assets.Scripts.ScreenVisualisers
{
    using Assets.Scripts.Interfaces;
    using UnityEngine;

    public class UpgradeButton : MonoBehaviour, IButton
    {
        private Vector3 oldCameraPosition;

        public GameObject camera;


        public void OnMouseOver()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            this.oldCameraPosition = this.camera.transform.position;
        }

        public void OnMouseExit()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        public void OnMouseDown()
        {
            camera.transform.position =
                new Vector3(camera.transform.position.x + 35, camera.transform.position.y, camera.transform.position.z);


            //camera.transform.position = this.oldCameraPosition;
        }

    }

}