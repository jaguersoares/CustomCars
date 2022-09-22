using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditFinish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreditsEnd());
    }

   IEnumerator CreditsEnd()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
