using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;

   // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 4;
            player.transform.Rotate(0, horizontalMove, 0);
            player.transform.Translate(0, 0, verticalMove);
        }
        else {
            isMoving = false;
        }
    }
}
