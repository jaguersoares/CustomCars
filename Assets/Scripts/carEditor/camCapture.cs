using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class camCapture : MonoBehaviour
{
    public RawImage camImage;
    public Material topMaterial;
    public Material sideMaterial;
    public Material frontMaterial;
    public Material backMaterial;
    public Texture2D defaultTexture;
    public static WebCamTexture webcamTexture;
    void Start()
    {
        webcamTexture = new WebCamTexture();
        camImage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
      //  camImage.uvRect = new Rect(1, 0, -1, 1);
       
        print(Application.persistentDataPath + "/1.png");
        StartCoroutine(refreshTexture());
    }
    public IEnumerator refreshTexture()
    {
        byte[] fileData;
        Texture2D tex = null;
        yield return new WaitForSeconds(0.10f);
        if (System.IO.File.Exists(Application.persistentDataPath + "/1.png"))
        {
            print("Busca");
            fileData = System.IO.File.ReadAllBytes(Application.persistentDataPath + "/1.png");
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
            topMaterial.SetTexture("_MainTex", tex);
        }else {
            topMaterial.SetTexture("_MainTex", defaultTexture);
        }

        if (System.IO.File.Exists(Application.persistentDataPath + "/2.png"))
        {
            fileData = System.IO.File.ReadAllBytes(Application.persistentDataPath + "/2.png");
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
            sideMaterial.SetTexture("_MainTex", tex);
        }
        else
        {
            sideMaterial.SetTexture("_MainTex", defaultTexture);
        }
        if (System.IO.File.Exists(Application.persistentDataPath + "/3.png"))
        {
            fileData = System.IO.File.ReadAllBytes(Application.persistentDataPath + "/3.png");
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
            frontMaterial.SetTexture("_MainTex", tex);
        }
        else
        {
            frontMaterial.SetTexture("_MainTex", defaultTexture);
        }
        if (System.IO.File.Exists(Application.persistentDataPath + "/4.png"))
        {
            fileData = System.IO.File.ReadAllBytes(Application.persistentDataPath + "/4.png");
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
            backMaterial.SetTexture("_MainTex", tex);
        }
        else
        {
            backMaterial.SetTexture("_MainTex", defaultTexture);
        }
    }
    private void Update()
    {
        if (changeAngle.carEditing == 1)
        {
            topMaterial.mainTexture = webcamTexture;
        }
        if (changeAngle.carEditing == 2)
        {
            sideMaterial.mainTexture = webcamTexture;
        }
        if (changeAngle.carEditing == 3)
        {
            frontMaterial.mainTexture = webcamTexture;
        }
        if (changeAngle.carEditing == 4)
        {
            backMaterial.mainTexture = webcamTexture;
        }
    }

}

