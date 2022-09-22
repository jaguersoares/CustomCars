using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int CarType=1;//1=red.2=blue.3=Green
    public GameObject TrackWindow;

    
    public void car1()
    {
        CarType=1;
        TrackWindow.SetActive(true);

    }
    public void car2()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }
    public void car3()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }
    public void custom()
    {
        CarType = 99;
        TrackWindow.SetActive(true);
    }

}
