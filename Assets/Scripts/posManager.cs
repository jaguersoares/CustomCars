using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class posManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject positionDisplay;
    private GameObject[] Players;
    private GameObject Car;
    public GameObject Car01;
    public GameObject Car02;
    public GameObject Car03;
    private int pos = 1;
    void Start()
    {

        
        StartCoroutine(FindPlayer());
        if (ModeSelect.RaceMode==0)StartCoroutine(ShowDisplay());
        //position = 4;
    }
    IEnumerator FindPlayer()
    {
        yield return new WaitForSeconds(0.01f);
        //Players = GameObject.FindGameObjectsWithTag("Player");
        Car = CarChoice.Car;
    }

    // Update is called once per frame
    void Update()
    {

        pos = 1;
        if (Car)
        {
            if ((Car.GetComponent<WaypointProgressTracker>().progressDistance) < (Car01.GetComponent<WaypointProgressTracker>().progressDistance)) pos = pos + 1;
            if ((Car.GetComponent<WaypointProgressTracker>().progressDistance) < (Car02.GetComponent<WaypointProgressTracker>().progressDistance)) pos = pos + 1;
            if ((Car.GetComponent<WaypointProgressTracker>().progressDistance) < (Car03.GetComponent<WaypointProgressTracker>().progressDistance)) pos = pos + 1;
        }

        // Array.Sort(pos);
        // for (int i = 0; i < pos.Length; i++)
        // {
        //   Console.WriteLine(i+"->"+pos[i]);
        // }
        //progressDistance = Way;
        if (ModeSelect.RaceMode == 0) positionDisplay.GetComponent<Text>().text = pos.ToString()+"/4";
    }

    IEnumerator ShowDisplay()
    {
        yield return new WaitForSeconds(8f);
        positionDisplay.SetActive(true);
    }
}