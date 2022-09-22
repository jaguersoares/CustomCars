using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nitro : MonoBehaviour
{
    public bool isReady = true;
    public AudioSource activateSound;
    public GameObject vehicle;
    public float waitTime;
 
 
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("left shift") && isReady)
        {
            StartCoroutine(Nitrous());
        }
    }

    IEnumerator Nitrous()
    {
        activateSound.Play();
        isReady = false;
        vehicle.GetComponent<Rigidbody>().AddForce(transform.forward * 1000, ForceMode.Acceleration);
        //vehicle.rigidbody.AddForce(transform.forward * 1000, ForceMode.Acceleration);
        yield return new WaitForSeconds(waitTime);
        isReady = true;
    }
}
