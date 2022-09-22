using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public GameObject lapComplete;
    public bool check = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lapComplete.GetComponent<BoxCollider>().enabled = true;
            check = true;
            print("Aqui"+check);
        }
    }
}
