using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public static event EventHandler OnMouseButtonDown; //event without any parameters
        public static event EventHandler<OnParameterEventHandler> OnParameter;

        private int _score;
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                // trigger an event
                OnMouseButtonDown?.Invoke(this, EventArgs.Empty);
            }

            if (Input.GetMouseButtonDown(1))
            {
                _score++;
                OnParameter?.Invoke(this, new OnParameterEventHandler
                {
                    SendValue = _score
                });
            }
        }
    }
}