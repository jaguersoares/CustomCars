using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
          private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }
        public float vButton;
        public float hButton;
        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");

//#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h+hButton, v+vButton, v+vButton, handbrake);
//            print(v + vButton);
//#else
//            m_Car.Move(h, v, v, 0f);
//#endif
        }

    }
}
