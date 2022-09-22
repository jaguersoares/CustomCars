using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeAngle : MonoBehaviour
{
    public GameObject car;
    public GameObject carTopButton;
    public GameObject topOutline;
    public GameObject sideOutline;
    public Sprite topButton;
    public Sprite selectedTopButton;
    public GameObject carSideButton;
    public Sprite sideButton;
    public Sprite selectedSideButton;
    public GameObject carFrontButton;
    public Sprite frontButton;
    public Sprite selectedFrontButton;
    public GameObject carBackButton;
    public Sprite backButton;
    public Sprite selectedBackButton;
    public static int carEditing;
    private Animator anim;
    void Start()
    {
        anim = car.GetComponent<Animator>();
        //carEditing = 1;
        print("Start");
        anim.SetInteger("condicao", 0);
    }
    public void changeAngleButton()
    {
        
        carTopButton.GetComponent<Image>().sprite = topButton;
        carSideButton.GetComponent<Image>().sprite = sideButton;
        carFrontButton.GetComponent<Image>().sprite = frontButton;
        carBackButton.GetComponent<Image>().sprite = backButton;
        anim.SetInteger("condicao", 0);
        topOutline.SetActive(false);
        sideOutline.SetActive(false);
        if (this.gameObject.name == "topButton")
        {
            topOutline.SetActive(true);
            carEditing = 1;
            anim.SetInteger("condicao", 1);
            carTopButton.GetComponent<Image>().sprite = selectedTopButton;
        }
        if (this.gameObject.name == "sideButton")
        {
            sideOutline.SetActive(true);
            carEditing = 2;
            anim.SetInteger("condicao", 2);
            carSideButton.GetComponent<Image>().sprite = selectedSideButton;
        }
        if (this.gameObject.name == "frontButton")
        {
            carEditing = 3;
            anim.SetInteger("condicao", 3);
            carFrontButton.GetComponent<Image>().sprite = selectedFrontButton;
        }
        if (this.gameObject.name == "backButton")
        {
            carEditing = 4;
            anim.SetInteger("condicao", 4);
            carBackButton.GetComponent<Image>().sprite = selectedBackButton;
        }
    }
}
