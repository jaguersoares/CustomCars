using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStableMini : MonoBehaviour
{
    public float CarX;
    public float CarY;
    public float CarZ;
    // Update is called once per frame
    void Update()
    {
        CarX = this.transform.eulerAngles.x;
        CarY = this.transform.eulerAngles.y;
        CarZ = this.transform.eulerAngles.z;
        this.transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
    }
}
