using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
    public GameObject greenButton;
    public int cashValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cashValue = GlobalCash.TotalCash;
        if(cashValue >= 100)
        {
        //    greenButton.GetComponent<Button>().interactable = true;
        }
    }
    public void GreenUnlock()
    {
        //greenButton.SetActive(false);
        cashValue -= 100;
        GlobalCash.TotalCash -= 100;
        //Salva o saldo do cara;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        //Salva o carro comprado;
        PlayerPrefs.SetInt("GreenBought", 100);
    }
}
