namespace Assets.Scripts.ScreenVisualisers
{
    using Assets.Scripts.Interfaces;
    using System;
    using UnityEngine;

    public class QuitButton : MonoBehaviour, IButton
    {
        public void OnMouseOver()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        public void OnMouseExit()
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        public void OnMouseDown()
        {
            Environment.Exit(0);
        }

    }

}