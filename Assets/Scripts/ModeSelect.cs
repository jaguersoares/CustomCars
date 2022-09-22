using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelect : MonoBehaviour
{
    public static int RaceMode=0;//0=Race;1=Score;2=Time;
    public GameObject TrackSelect;
    public GameObject carIcon1;
    public GameObject carIcon2;
    public GameObject carIcon3;
    public GameObject carIcon99;
    public Color enabledColor;
    public Color disabledColor;

    public void TimeMode()
    {
        RaceMode = 2;
        TrackSelect.SetActive(true);
        refreshSelectedCar();

    }
    public void TheRaceMode()
    {
        RaceMode = 0;
        TrackSelect.SetActive(true);
        refreshSelectedCar();
    }
    public void ScoreMode()
    {
        RaceMode = 1;
        TrackSelect.SetActive(true);
        refreshSelectedCar();
    }
    //FORÇADO
    

    public void refreshSelectedCar()
    {
        var colors = carIcon1.GetComponent<Button>().colors;
        colors.normalColor = disabledColor;
        carIcon1.GetComponent<Button>().colors = colors;
        carIcon2.GetComponent<Button>().colors = colors;
        carIcon3.GetComponent<Button>().colors = colors;
        carIcon99.GetComponent<Button>().colors = colors;
        colors.normalColor = enabledColor;
        if (GlobalCar.CarType == 1) {
            print("aqui");
            carIcon1.GetComponent<Button>().colors = colors;
        }
        if (GlobalCar.CarType == 2) {
            carIcon2.GetComponent<Button>().colors = colors;
        }
        if (GlobalCar.CarType == 3)
        {
            carIcon3.GetComponent<Button>().colors = colors;
        }
        if (GlobalCar.CarType == 99)
        {
            carIcon99.GetComponent<Button>().colors = colors;
        }

    }
}
