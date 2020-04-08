using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerPlayer : MonoBehaviour
{
    //reference to the animator
    Animator anim;

    private void Start()
    {
        //find the animator.
        anim = this.GetComponent<Animator>();
    }

    public void moving() {
        anim.SetBool("Moving", true);
        anim.SetBool("Idle", false);
        anim.SetBool("Attacking", false);

    }

    public void idle() {
        anim.SetBool("Moving", false);
        anim.SetBool("Idle", true);
        anim.SetBool("Attacking", false);
    }

    public void attack() {
        anim.SetBool("Moving", false);
        anim.SetBool("Idle", false);
        anim.SetBool("Attacking", true);
    }

}
