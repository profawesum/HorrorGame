using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeycards : MonoBehaviour
{

    public string keycardType;
    public KeycardUI ui;
    public Pickups pickup;

    private void Start()
    {
        //get the pickups script
        pickup = GameObject.FindGameObjectWithTag("Player").GetComponent<Pickups>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") {
            pickup.enableText();
            if (Input.GetButtonDown("Pickup"))
            {
                //give the player the keycard
                if (keycardType == "Yellow")
                {
                    Keycards.gotYellowCard = true;
                    ui.keycardUIEnable("Yellow");
                    pickup.removeText();
                }
                if (keycardType == "Red")
                {
                    Keycards.gotRedCard = true;
                    ui.keycardUIEnable("Red");
                    pickup.removeText();
                }
                if (keycardType == "Green")
                {
                    Keycards.gotGreenCard = true;
                    ui.keycardUIEnable("Green");
                    pickup.removeText();
                }
                if (keycardType == "Blue")
                {
                    Keycards.gotBlueCard = true;
                    ui.keycardUIEnable("Blue");
                    pickup.removeText();
                }
                //destroy the keycard
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pickup.removeText();
    }
}
