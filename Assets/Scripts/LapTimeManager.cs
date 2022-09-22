using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    //Static pode ser referenciada em um outro script
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    //Tempo
    public static float RawTime;
    void Update()
    {
        RawTime += Time.deltaTime;
        MilliCount += Time.deltaTime * 10;
      //  MilliCount = Mathf.Round(MilliCount);
        // Converteu para Strig
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = ""+MilliDisplay;

        if(MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }
        // zero a esquerda
        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount+".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = SecondCount + ".";
        }

        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }
        
        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0"+MinuteCount+":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = MinuteCount + ":";
        }


    }
}
