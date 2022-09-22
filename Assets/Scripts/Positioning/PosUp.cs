using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour
{
    //public GameObject positionDisplay;
    public GameObject playerRotation;
    public float carX;
    public float carY;
    public float carZ;
    void Update()
    {
        
        carX = playerRotation.transform.eulerAngles.x;
        carY = playerRotation.transform.eulerAngles.y;
        carZ = playerRotation.transform.eulerAngles.z;
        this.transform.eulerAngles = new Vector3(carX, carY, carZ);
    }

    // o Other retorna o cara que saiu desse trigger, adiversário
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPos")
        {
            //posManager.position = posManager.position - 1;
            //positionDisplay.GetComponent<Text>().text = "First Place";
        }
    }
}
