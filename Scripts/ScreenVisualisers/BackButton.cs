namespace Assets.Scripts.ScreenVisualisers
{
    using Assets.Scripts.Interfaces;
    using UnityEngine;

    public class BackButton : MonoBehaviour, IButton
    {
        public GameObject mainCamera;

        public void OnMouseOver()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }

        public void OnMouseExit()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        public void OnMouseDown()
        {
            this.mainCamera.transform.position =
                new Vector3(mainCamera.transform.position.x - 35, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
    }

}