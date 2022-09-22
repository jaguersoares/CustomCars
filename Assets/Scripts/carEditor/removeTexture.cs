using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeTexture : MonoBehaviour
{

    //private string _SavePath = Application.persistentDataPath;
    public GameObject camCampure;
    public GameObject topOutline;
    public GameObject sideOutline;
    private Animator anim;
    public GameObject car;
    public void RemoveTextureFunction()
    {
        anim = car.GetComponent<Animator>();
        if (changeAngle.carEditing > 0) {
            //System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + changeAngle.carEditing.ToString() + ".png", snap.EncodeToPNG());
            System.IO.File.Delete(Application.persistentDataPath + "/" + changeAngle.carEditing.ToString() + ".png");
            changeAngle.carEditing = 0;
            StartCoroutine(camCampure.GetComponent<camCapture>().refreshTexture());
            anim.SetInteger("condicao", 0);
            topOutline.SetActive(false);
            sideOutline.SetActive(false);
        }
    }
}
