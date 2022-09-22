using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTRigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    
    //Quanti a tiva o trogger
    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }

}
