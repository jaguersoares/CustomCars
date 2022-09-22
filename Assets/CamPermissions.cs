using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif
using UnityEngine.UI;
public class CamPermissions : MonoBehaviour
{
    //public static WebCamTexture webcamTexture;
    // Start is called before the first frame update
    void Start()
    {
//        #if PLATFORM_ANDROID
        Permission.RequestUserPermission(Permission.Camera);
        //#endif
        //webcamTexture = new WebCamTexture();
        //webcamTexture.Play();
        //webcamTexture.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
