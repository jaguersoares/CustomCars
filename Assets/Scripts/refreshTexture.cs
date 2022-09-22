using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refreshTexture : MonoBehaviour
{
    public Material topMaterial;
    public Material sideMaterial;
    public Material frontMaterial;
    public Material backMaterial;
    public Texture2D defaultTexture;
    private void Start()
    {
        StartCoroutine(goTexture());
    }
    public IEnumerator goTexture()
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
        }
        else
        {
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
}
