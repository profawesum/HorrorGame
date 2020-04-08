using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;

    public float rotateSpeed = 150;
    public float movementSpeed = 2;

    public AnimationControllerPlayer animController;

   // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
            player.transform.Rotate(0, horizontalMove, 0);
            player.transform.Translate(0, 0, verticalMove);
        }
        else {
            isMoving = false;
            animController.idle();
        }

        if (isMoving) {
            animController.moving();
        }
    }
}
