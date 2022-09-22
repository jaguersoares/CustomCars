using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public int GreenSelect;
    public GameObject FakeGreen;
    void Start()
    {
        GreenSelect = PlayerPrefs.GetInt("GreenBought");
        print ("aaaa="+ GreenSelect);
        if (GreenSelect == 100)
        {
            FakeGreen.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
