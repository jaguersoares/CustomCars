using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;
    // Start is called before the first frame update
    void Start()
    {
        print("load");
        if (ButtonOptions.selectedTrack == 1)
        {
            MinCount = PlayerPrefs.GetInt("MinSaveTrack01");
            SecCount = PlayerPrefs.GetInt("SecSaveTrack01");
            MilliCount = PlayerPrefs.GetFloat("MilliTrack01");
        }
        if (ButtonOptions.selectedTrack == 2)
        {
            MinCount = PlayerPrefs.GetInt("MinSaveTrack02");
            SecCount = PlayerPrefs.GetInt("SecSaveTrack02");
            MilliCount = PlayerPrefs.GetFloat("MilliTrack02");
        }
        if (ButtonOptions.selectedTrack == 3)
        {
            MinCount = PlayerPrefs.GetInt("MinSaveTrack03");
            SecCount = PlayerPrefs.GetInt("SecSaveTrack03");
            MilliCount = PlayerPrefs.GetFloat("MilliTrack03");
        }
        //print("Sec-"+SecCount);
        MilliCount = Mathf.Round(MilliCount);
        MinDisplay.GetComponent<Text>().text = "" + MinCount+":";
        SecDisplay.GetComponent<Text>().text = "" + SecCount + ".";


        if (SecCount <= 9)
        {
            SecDisplay.GetComponent<Text>().text = "0" + SecCount + ".";
        }
        else
        {
            SecDisplay.GetComponent<Text>().text = SecCount + ".";
        }
        if (MinCount <= 60)
        {
            MinDisplay.GetComponent<Text>().text = "0" + MinCount + ".";
        }
        else
        {
            MinDisplay.GetComponent<Text>().text = MinCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;
    }

}
