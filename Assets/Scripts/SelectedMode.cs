using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectedMode : MonoBehaviour
{
    // Start is called before the first frame update
    public int ModeSelection;
    public GameObject Car01;
    public GameObject Car02;
    public GameObject Car03;
    public GameObject LapPanel;
    public GameObject PosPanel;
    void Start()
    {
        //0=Race;1=Score;2=Time;
        
        //RACE MODE
        if (ModeSelect.RaceMode == 0)
        {
            LapPanel.SetActive(true);
//            PosPanel.SetActive(true);
            Car01.SetActive(true);
            Car02.SetActive(true);
            Car03.SetActive(true);
        }
        //TIME MODE
        if (ModeSelect.RaceMode == 2)
        {
            LapPanel.SetActive(false);
            PosPanel.SetActive(false);
            Car01.SetActive(false);
            Car02.SetActive(false);
            Car03.SetActive(false);
        }

    }


}
