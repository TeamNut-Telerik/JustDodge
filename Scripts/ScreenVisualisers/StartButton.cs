namespace Assets.Scripts.ScreenVisualisers
{
    using UnityEngine;

    public class StartButton : MonoBehaviour
    {
        void OnMouseOver()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }

        void OnMouseExit()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        void OnMouseDown()
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }

    }

}