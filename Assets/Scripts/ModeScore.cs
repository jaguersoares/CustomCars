using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ModeScore : MonoBehaviour
{
    // Start is called before the first frame update
    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
    public GameObject ScoreObjects;
    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;
        print("RM:" + ModeSelection);
        if (ModeSelection == 1)
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            ScoreObjects.SetActive(true);
        }
    }
    private void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
    }

}
