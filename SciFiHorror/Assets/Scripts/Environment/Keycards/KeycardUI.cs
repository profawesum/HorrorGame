using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardUI : MonoBehaviour
{

    public GameObject blueKeycard;
    public GameObject redKeycard;
    public GameObject yellowKeycard;
    public GameObject greenKeycard;

    private void Start()
    {
        blueKeycard.SetActive(false);
        redKeycard.SetActive(false);
        yellowKeycard.SetActive(false);
        greenKeycard.SetActive(false);
    }

    public void keycardUIEnable(string keycardType) {
        if (keycardType == "Blue") {
            blueKeycard.SetActive(true);
        }
        if (keycardType == "Yellow")
        {
            yellowKeycard.SetActive(true);
        }
        if (keycardType == "Green")
        {
            greenKeycard.SetActive(true);
        }
        if (keycardType == "Red")
        {
            redKeycard.SetActive(true);
        }
    }
}
