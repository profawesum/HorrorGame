using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{

    [Header("Does the door require a keycard?")]
    //reference for which keycard the door requires
    public bool yellowCard;
    public bool redCard;
    public bool blueCard;
    public bool greenCard;
    public bool noCard;

    [Header("Reference to the animator")]
    //reference to the animator
    public Animator animator;

    private void Start()
    {
        //find the animator
        animator = this.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (yellowCard && Keycards.gotYellowCard) {
            openTheDoor();
        }
        if (redCard && Keycards.gotRedCard)
        {
            openTheDoor();
        }
        if (blueCard && Keycards.gotBlueCard)
        {
            openTheDoor();
        }
        if (greenCard && Keycards.gotGreenCard)
        {
            openTheDoor();
        }
        if (noCard) {
            openTheDoor();
        }
    }


    //what to do if the door should open
    public void openTheDoor() {
        animator.SetBool("character_nearby", true);   
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("character_nearby", false);
    }

}


