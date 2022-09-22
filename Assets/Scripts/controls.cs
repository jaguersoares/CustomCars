using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class controls : MonoBehaviour
{
    public GameObject Car01;
    public GameObject Car02;
    public GameObject Car03;
    public GameObject Car99;
    public GameObject Car;
    public bool vState;
    public bool hState;
    private void Start()
    {
      print("Carro-"+GlobalCar.CarType);
      if (GlobalCar.CarType == 1) Car = Car01;
      if (GlobalCar.CarType == 2) Car = Car02;
      if (GlobalCar.CarType == 3) Car = Car03;
      if (GlobalCar.CarType == 99) Car = Car99;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) Car.GetComponent<CarUserControl>().hButton = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) Car.GetComponent<CarUserControl>().hButton = -1;
        if (Input.GetKey(KeyCode.UpArrow)) Car.GetComponent<CarUserControl>().vButton = 1;
        if (Input.GetKey(KeyCode.DownArrow)) Car.GetComponent<CarUserControl>().vButton = -1;
        if ((Input.GetKeyUp(KeyCode.RightArrow))||(Input.GetKeyUp(KeyCode.LeftArrow))) Car.GetComponent<CarUserControl>().hButton = 0;
        if ((Input.GetKeyUp(KeyCode.UpArrow)) || (Input.GetKeyUp(KeyCode.DownArrow))) Car.GetComponent<CarUserControl>().vButton = 0;
    }
    public void accel()
    {
        vState = true;
        //StartCoroutine(ChangeSpeed(0, 1, 0.5f));
        Car.GetComponent<CarUserControl>().vButton = 1;
    }
    public void back()
    {
        vState = true;
        //StartCoroutine(ChangeSpeed(0, -1, 0.5f));
        Car.GetComponent<CarUserControl>().vButton = -1;
    }
    public void exitV()
    {
        vState = false;
        Car.GetComponent<CarUserControl>().vButton = 0;
    }
    public void turnLeft()
    {
        hState = true;
        StartCoroutine(ChangeDirection(0, -1, 0.5f));
        //Car.GetComponent<CarUserControl>().hButton = -1;
    }
    public void turnRight()
    {
        hState = true;
        StartCoroutine(ChangeDirection(0, 1, 0.5f));
        //Car.GetComponent<CarUserControl>().hButton = 1;
    }
    public void exitH()
    {
        print("Exit");
        hState = false;
        Car.GetComponent<CarUserControl>().hButton = 0;
    }
    IEnumerator ChangeSpeed(float v_start, float v_end, float duration)
    {
        float elapsed = 0.0f;
        while ((elapsed < duration)&&(vState==true))
        {
            Car.GetComponent<CarUserControl>().vButton = Mathf.Lerp(v_start, v_end, elapsed / duration);
            elapsed += Time.deltaTime;
            if (vState == false)
            {
                Car.GetComponent<CarUserControl>().vButton = 0;
                yield break;
            }
            yield return null;
        }
        Car.GetComponent<CarUserControl>().vButton = v_end;
    }

    IEnumerator ChangeDirection(float v_start, float v_end, float duration)
    {
        float elapsed = 0.0f;
        while ((elapsed < duration))
        {
            Car.GetComponent<CarUserControl>().hButton = Mathf.Lerp(v_start, v_end, elapsed / duration);
            elapsed += Time.deltaTime;
            if (hState == false)
            {
                Car.GetComponent<CarUserControl>().hButton = 0;
                yield break;
            }
            yield return null;
        }
        Car.GetComponent<CarUserControl>().hButton = v_end;
    }
}

