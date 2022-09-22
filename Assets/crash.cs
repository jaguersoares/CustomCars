using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    IEnumerator OnTriggerEnter(Collider collision)
    {
        print(collision.gameObject.tag);
        if ((collision.gameObject.tag != "CheckPoint")&& (collision.gameObject.tag != "wheel"))
        {

            car.GetComponent<AudioSource>().Play();
//            this.GetComponent<BoxCollider>().enabled = false;
            yield return new WaitForSeconds(1);
//            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
