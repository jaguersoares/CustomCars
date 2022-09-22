using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avoidTurn : MonoBehaviour
{
    float xRotationLimit = 45;
    float yRotationLimit = 60;
    float zRotationLimit = 45;

    public GameObject TheCar;
    private float CarX;
    private float CarY;
    private float CarZ;
    private float NewX;
    private float NewY;
    private float NewZ;
    public bool rotate = false;
    private char axis;
    // Update is called once per frame
    private void Start()
    {
        //TheCar.transform.eulerAngles = new Vector3(0, 0, 0);
    }

    void Update()
    {
        CarX = TheCar.transform.rotation.x*100;
        CarY = TheCar.transform.rotation.y*100;
        CarZ = TheCar.transform.rotation.z*100;
        float speed=200;
        if (!rotate)
        {
            var step = speed * Time.deltaTime;
            if (CarX > xRotationLimit)
            {
                print("X MAIOR->" + CarX + " - " + xRotationLimit);
                TheCar.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, TheCar.transform.rotation.y, TheCar.transform.rotation.z), step);
                //TheCar.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, TheCar.transform.rotation.y, TheCar.transform.rotation.z), 1000f * Time.deltaTime);

            }
            if (CarX < (xRotationLimit * -1))
            {
                print("X MENOR->" + CarX);
                TheCar.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, TheCar.transform.rotation.y, TheCar.transform.rotation.z), step);

            }
            if (CarZ > zRotationLimit)
            {
                TheCar.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(TheCar.transform.rotation.z, TheCar.transform.rotation.y, 0), step);


            }
            if (CarZ < (zRotationLimit * -1))
            {
                TheCar.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(TheCar.transform.rotation.z, TheCar.transform.rotation.y, 0), step);


            }
        }
       // if (rotate) TheCar.transform.Rotate(NewX, NewY, NewZ);
    }
}
