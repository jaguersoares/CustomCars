using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 25;
        gameObject.SetActive(false);
    }

}
