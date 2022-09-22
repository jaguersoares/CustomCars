using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recover : MonoBehaviour
{
    public GameObject Enemy01;
    public GameObject Enemy02;
    public GameObject Enemy03;
    private GameObject Car;

    private void Start()
    {
        Car = CarChoice.Car;
    }


    public void RecPlayer()
    {
        recover(Car);
    }
    void Update()
    {
        if (Input.GetButtonDown("Recover"))
        {
//            print("Recover");
            StartCoroutine(ModeChange(Car));
        }
        if (Enemy01.GetComponent<lastPosition>().lastTime > 5000) recover(Enemy01);
        if (Enemy02.GetComponent<lastPosition>().lastTime > 5000) recover(Enemy02);
        if (Enemy03.GetComponent<lastPosition>().lastTime > 5000) recover(Enemy03);
    }

    public void recover(GameObject target) {
        
        StartCoroutine(ModeChange(target));
    }


    IEnumerator ModeChange(GameObject target)
    {
        
        if (target.gameObject.tag == "player")
        {
            target.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            target.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
            target.transform.eulerAngles = target.GetComponent<lastPosition>().lastRotation;
            target.transform.position = target.GetComponent<lastPosition>().lastPos;
        }
        else
        {
            //target.GetComponent<BoxCollider>().enabled = false;
            target.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            target.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
            target.transform.eulerAngles = target.GetComponent<lastPosition>().lastRotation;
            target.transform.position = target.GetComponent<lastPosition>().lastPos;
            target.GetComponent<WaypointProgressTracker>().progressDistance = target.GetComponent<lastPosition>().lastDistance;
            target.GetComponent<Rigidbody>().velocity = target.GetComponent<Rigidbody>().transform.forward * 10;
            yield return new WaitForSeconds(0.01f);
            //target.GetComponent<BoxCollider>().enabled = true;
        }

        
        

        //rb.velocity = Vector3.Scale(rb.velocity, new Vector3(0f, 1f, 1f));
        //Car.transform.position = checkPoint.checkPointAntPos;
        //Car.transform.eulerAngles = checkPoi//

    }
}
