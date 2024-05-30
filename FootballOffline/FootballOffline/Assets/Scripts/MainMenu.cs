using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MainMenu : MonoBehaviour
    {
        private Vector2 CANVAS_SIZE;
        private GameObject BG;

        private void Start()
        {
            BG = new();
            BG.transform.SetParent(transform, false);
            var overlay = BG.AddComponent<Image>();
            overlay.color = Color.black;

            CANVAS_SIZE = transform.GetComponent<RectTransform>().sizeDelta;
            overlay.GetComponent<RectTransform>().sizeDelta = CANVAS_SIZE;

            SetButton();
        }

        private void SetButton(){
            var startButton = new GameObject("StartButton");
            startButton.transform.SetParent(BG.transform, false);
            var view    = startButton.AddComponent<Image>();
            var button  = startButton.AddComponent<Button>();

                
        }
    }

}
