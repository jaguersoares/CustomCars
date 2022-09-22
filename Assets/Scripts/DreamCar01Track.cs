using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject[] marks;
    public int MarkTracker;
    int count = 0;
    // Update is called once per frame
    void Update()
    {
        for (count = 0; count < marks.Length; count++ )
        {
            if (MarkTracker==count)TheMarker.transform.position = marks[count].transform.position;
        }
    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled=false;
            MarkTracker += 1;
            if (MarkTracker == marks.Length)
            {
                MarkTracker = 0;
            }
            print(MarkTracker);
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
