using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject MinuteDisplay;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public AudioSource FinishMusic;
    public AudioSource FinishAplause;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameObject LapCounter;
    public Animator RecordAnim;
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;
    private GameObject Car;
    public int LapsDone=0;
    public int TotalLaps;
    public float RawTime;

    public GameObject RaceFinish;
    //public GameObject LapTimeBox;

    private void Update()
    {

    }
    private void Start()
    {
        Car = CarChoice.Car;
        LapCounter.GetComponent<Text>().text = "0 / "+TotalLaps.ToString();
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LapsDone += 1;
            if (ButtonOptions.selectedTrack == 1)
            {
                RawTime = PlayerPrefs.GetFloat("RawTimeTrack01");
            }
            if (ButtonOptions.selectedTrack == 2)
            {
                RawTime = PlayerPrefs.GetFloat("RawTimeTrack02");
            }
            if (ButtonOptions.selectedTrack == 3)
            {
                RawTime = PlayerPrefs.GetFloat("RawTimeTrack03");
            }
            //RawTime = 0;
            // Compara com o RawTime do outro Script
            print(LapTimeManager.RawTime + " - para - " + RawTime);
            if ((LapTimeManager.RawTime <= RawTime) || (RawTime == 0))
            {
                RecordAnim.SetTrigger("start");
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = LapTimeManager.SecondCount + ".";
                }
                if (LapTimeManager.MinuteCount <= 60)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = LapTimeManager.MinuteCount + ".";
                }

                MilliDisplay.GetComponent<Text>().text = "" + Mathf.Round(LapTimeManager.MilliCount);
                // Variavel interna Unity
                if (ButtonOptions.selectedTrack == 1) { 
                    PlayerPrefs.SetInt("MinSaveTrack01", LapTimeManager.MinuteCount);
                   PlayerPrefs.SetInt("SecSaveTrack01", LapTimeManager.SecondCount);
                    PlayerPrefs.SetFloat("MilliSaveTrack01", LapTimeManager.MilliCount);
                    PlayerPrefs.SetFloat("RawTimeTrack01", LapTimeManager.RawTime);
                }
                if (ButtonOptions.selectedTrack == 2) { 
                    PlayerPrefs.SetInt("MinSaveTrack02", LapTimeManager.MinuteCount);
                    PlayerPrefs.SetInt("SecSaveTrack02", LapTimeManager.SecondCount);
                    PlayerPrefs.SetFloat("MilliSaveTrack02", LapTimeManager.MilliCount);
                    PlayerPrefs.SetFloat("RawTimeTrack02", LapTimeManager.RawTime);
                }
               if (ButtonOptions.selectedTrack == 3) { 
                    PlayerPrefs.SetInt("MinSaveTrack03", LapTimeManager.MinuteCount);
                    PlayerPrefs.SetInt("SecSaveTrack03", LapTimeManager.SecondCount);
                    PlayerPrefs.SetFloat("MilliSaveTrack03", LapTimeManager.MilliCount);
                    PlayerPrefs.SetFloat("RawTimeTrack03", LapTimeManager.RawTime);
                }
    //RecordAnim.SetInteger("newRecord", 0);
    //RecordAnim["AnimationName"].wrapMode = WrapMode.Once;
    RecordAnim.Play("newRecord");
                FinishAplause.Play();
                //animation.Play("AnimationName");
            }
            if (LapsDone == 1) Obstacle1.SetActive(true);
            if (LapsDone == 2) Obstacle2.SetActive(true);
            if (LapsDone == 3) Obstacle3.SetActive(true);

            if (LapsDone == TotalLaps)
            {
                LevelMusic.SetActive(false);
                FinishMusic.Play();
                FinishAplause.Play();
                ViewModes.SetActive(false);
                FinishCam.SetActive(true);
                print("FIM");
                Car.GetComponent<Rigidbody>().drag = 20;
            }

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            LapTimeManager.RawTime = 0;
            LapCounter.GetComponent<Text>().text = "" + LapsDone + " / "+TotalLaps.ToString();
            //LapCompleteTrig.SetActive(false);
            LapCompleteTrig.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
