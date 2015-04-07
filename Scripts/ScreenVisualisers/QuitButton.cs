namespace Assets.Scripts.ScreenVisualisers
{
    using System;
    using UnityEngine;

    public class QuitButton : MonoBehaviour
    {
        void OnMouseOver()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        void OnMouseExit()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        void OnMouseDown()
        {
            Environment.Exit(0);
        }

    }

}