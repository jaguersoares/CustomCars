using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastPosition : MonoBehaviour
{
    public Vector3 lastPos;
    public Vector3 lastRotation;
    public float lastTime;
    public float lastDistance;
    public static float MilliCount;
    public static float SecCount;
    public static float RawTime;
    public GameObject[] checkPoints;
    int count = 0;
    // Update is called once per frame
    private void Start()
    {
        lastPos = this.transform.position;
        lastDistance = this.GetComponent<WaypointProgressTracker>().progressDistance;
    }
    void Update()
    {
        RawTime += Time.deltaTime;
        MilliCount += Time.deltaTime * 10;
        if (MilliCount >= 10)
        {
            lastTime += 1;
        }
    }

        IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "CheckPoint")
        {
            lastPos = collision.gameObject.transform.position;
            lastRotation = collision.transform.eulerAngles;
            lastTime = 0;
            if (this.GetComponent<WaypointProgressTracker>().progressDistance > lastDistance) lastDistance = this.GetComponent<WaypointProgressTracker>().progressDistance;
            yield return new WaitForSeconds(1);
        }
    }
}
