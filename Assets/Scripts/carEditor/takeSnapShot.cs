using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeSnapShot : MonoBehaviour
{

    //private string _SavePath = Application.persistentDataPath;
    int _CaptureCounter = 1;
    public GameObject camCampure;
    private Animator anim;
    public GameObject car;
    public void TakeSnapshotfunction()
    {
        if (changeAngle.carEditing > 0) {
            anim = car.GetComponent<Animator>();
            print("aqui");
            Texture2D snap = new Texture2D(camCapture.webcamTexture.width, camCapture.webcamTexture.height);
            snap.SetPixels(camCapture.webcamTexture.GetPixels());
            snap.Apply();

            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + changeAngle.carEditing.ToString() + ".png", snap.EncodeToPNG());
            ++_CaptureCounter;
            changeAngle.carEditing = 0;
            StartCoroutine(camCampure.GetComponent<camCapture>().refreshTexture());
            anim.SetInteger("condicao", 0);
        }
    }
}
