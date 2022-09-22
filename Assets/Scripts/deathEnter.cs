using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathEnter : MonoBehaviour
{
    public GameObject recover;
    public GameObject target;
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if ((collision.gameObject.tag == "Player")|| (collision.gameObject.tag == "Enemy"))
        {
            recover.GetComponent<Recover>().recover(collision.gameObject);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
