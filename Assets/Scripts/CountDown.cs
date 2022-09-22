using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{
    public GameObject CountDownObject;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource LevelMusic;
    public GameObject LapTimer;
    private GameObject Car;
    public GameObject Car01;
    public GameObject Car02;
    public GameObject Car03;

    public float initialDrag;

    // Start is called before the first frame update
    void Start()
    {
        Car = CarChoice.Car;
        initialDrag = Car.GetComponent<Rigidbody>().drag;
        StartCoroutine(countStart());
    }

    IEnumerator countStart()
    {
        //Sequencia de contage
        Car.GetComponent<Rigidbody>().drag = 20;
        Car01.GetComponent<CarAIControl>().enabled = false;
        Car02.GetComponent<CarAIControl>().enabled = false;
        Car03.GetComponent<CarAIControl>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        CountDownObject.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDownObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownObject.SetActive(false);
        CountDownObject.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDownObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownObject.SetActive(false);
        CountDownObject.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDownObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownObject.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        Car.GetComponent<Rigidbody>().drag = initialDrag;
        Car01.GetComponent<CarAIControl>().enabled = true;
        Car02.GetComponent<CarAIControl>().enabled = true;
        Car03.GetComponent<CarAIControl>().enabled = true;
        //Car01.GetComponent<Rigidbody>().drag = initialDrag;
        //Car02.GetComponent<Rigidbody>().drag = initialDrag;
        //Car03.GetComponent<Rigidbody>().drag = initialDrag;

        //        CarController.m_Topspeed = initialSpeed;
        //        (CarControls.GetComponent("CarController") as MonoBehaviour).enabled = true;
        //        (DreamCarCarControls.GetComponent("CarController") as MonoBehaviour).enabled = true;
    }
}

