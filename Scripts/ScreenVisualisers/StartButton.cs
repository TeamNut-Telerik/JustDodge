namespace Assets.Scripts.ScreenVisualisers
{
    using Assets.Scripts.Interfaces;
    using UnityEngine;

    public class StartButton : MonoBehaviour, IButton
    {
        public void OnMouseOver()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }

        public void OnMouseExit()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        public void OnMouseDown()
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }

    }

}