using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        // public/private type name
        public GameObject hudRestart;

        private Image background;

        private void Awake()
        {
            background = hudRestart.GetComponent<Image>();
        }

        private void OnTriggerEnter(Collider other)
        {
            hudRestart.SetActive(true);
            background.color = Color.black;
        }
        private void OnTriggerExit(Collider other)
        {
            //HUD Restart.enabled = false;
        }

        public void OnButtonRestart() {
            Debug.Log("OnButtonRestart!");
        }
    }
}
