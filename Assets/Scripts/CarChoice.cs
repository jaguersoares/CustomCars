using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    //1 red 2 blue
    public GameObject Player01;
    public GameObject Player02;
    public GameObject Player03;
    public GameObject Player99;
    public static GameObject Car;
    public int CarImport;
    // Start is called before the first frame update
    void Start()
    {
//        print("GlobalCar-"+GlobalCar.CarType);
         CarImport = GlobalCar.CarType;
        //CarImport =2;
        if (CarImport == 1)
        {
            Player02.SetActive(false);
            Player03.SetActive(false);
            Player99.SetActive(false);
            Car = Player01;
        }
        if (CarImport == 2)
        {
            Player01.SetActive(false);
            Player03.SetActive(false);
            Player99.SetActive(false);
            Car = Player02;
        }
        if (CarImport == 3)
        {
            Player01.SetActive(false);
            Player02.SetActive(false);
            Player99.SetActive(false);
            Car = Player03;
        }
        if (CarImport == 99)
        {
            Player01.SetActive(false);
            Player02.SetActive(false);
            Player03.SetActive(false);
            Car = Player99;
        }
    }


}
