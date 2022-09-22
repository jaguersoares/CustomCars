﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public int CamMode;
    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }
            else
            {
                CamMode++;
            }
            StartCoroutine(ModeChange());
        }
    }

    public void changeCamera()
    {
        if (CamMode == 1)
        {
            CamMode = 0;
        }
        else
        {
            CamMode++;
        }
        StartCoroutine(ModeChange());
    }
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FarCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
    }
}
