using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror : MonoBehaviour
{
    private GameObject car;
    public GameObject mirrorPlayer;
    public GameObject player99;
    public GameObject player01;
    public GameObject player02;
    public GameObject player03;
    public GameObject Enemy01;
    public GameObject Enemy02;
    public GameObject Enemy03;
    public GameObject mirrorEnemy01;
    public GameObject mirrorEnemy02;
    public GameObject mirrorEnemy03;
    // Start is called before the first frame update
    void Start()
    {
        print("aaa" + GlobalCar.CarType);
        if (GlobalCar.CarType == 1) car = player01;
        if (GlobalCar.CarType == 2) car = player02;
        if (GlobalCar.CarType == 3) car = player03;
        if (GlobalCar.CarType == 99) car = player99;
    }

    // Update is called once per frame
    void Update()
    {
        mirrorPlayer.transform.position = new Vector3(car.transform.position.x-1000, car.transform.position.y, car.transform.position.z);
        mirrorPlayer.transform.eulerAngles = car.transform.eulerAngles;
        mirrorEnemy01.transform.position = new Vector3(Enemy01.transform.position.x - 1000, Enemy01.transform.position.y, Enemy01.transform.position.z);
        mirrorEnemy02.transform.position = new Vector3(Enemy02.transform.position.x - 1000, Enemy02.transform.position.y, Enemy02.transform.position.z);
        mirrorEnemy03.transform.position = new Vector3(Enemy03.transform.position.x - 1000, Enemy03.transform.position.y, Enemy03.transform.position.z);
    }
}
