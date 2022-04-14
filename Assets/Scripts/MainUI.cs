using System;
using UnityEngine;
using UnityEngine.UI;
namespace DefaultNamespace
{
    public class MainUI : MonoBehaviour
    {
        public Text textLeft, textRight;
        private int _score;

        private void Awake()
        {
            _score = 0;
            textLeft.text = _score.ToString();
        }

        private void OnEnable()
        {
            //subscribing to the event
            Player.OnMouseButtonDown += PlayerOnOnMouseButtonDown;
            Player.OnParameter += PlayerOnOnParameter;
        }

        private void PlayerOnOnParameter(object sender, OnParameterEventHandler e)
        {
            textRight.text = e.SendValue.ToString();
        }

        private void PlayerOnOnMouseButtonDown(object sender, EventArgs e)
        {
            _score++;
            textLeft.text = _score.ToString();
        }

        private void OnDisable()
        {
            //un subscribing to the event
            Player.OnMouseButtonDown -= PlayerOnOnMouseButtonDown;
            Player.OnParameter += PlayerOnOnParameter;
        }
    }
}