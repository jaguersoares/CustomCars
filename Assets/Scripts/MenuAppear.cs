using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{
    public GameObject BigButton;
    public GameObject Buttons;
    // Start is called before the first frame update
    public void ShowButtons()
    {
        BigButton.SetActive(false);
        Buttons.SetActive(true);
    }
}
