using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float walkSpeed = 3;
    public float runSpeed = 6;
    public float jumpSpeed = 6;
    public float doubleJumpSpeed = 6;

    private bool canDoubleJump;

    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        // jump
        if (Input.GetKey("space")) {
            if (CheckGround.isGrounded) {
                canDoubleJump = true;
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            }
            else if (Input.GetKeyDown("space")){
                if (canDoubleJump) {
                    rb2D.velocity = new Vector2(rb2D.velocity.x, doubleJumpSpeed);
                    canDoubleJump = false;
                }
            } 
        }
    }

    void FixedUpdate()
    {   
        // horizontal move
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb2D.velocity = new Vector2(walkSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left")) {
            rb2D.velocity = new Vector2(-walkSpeed, rb2D.velocity.y);
        }
        else {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

    }
}
