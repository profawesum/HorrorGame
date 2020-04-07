using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{

    public GameObject interactText;

    private void Start()
    {
        interactText.SetActive(false);
    }

    public void enableText() {
        interactText.SetActive(true);
    }

    public void removeText() {
        interactText.SetActive(false);
    }


}
