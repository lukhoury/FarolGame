using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 10f;
    public float speedJump = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = 0f;

        // Horizontal Movement
        if (Input.GetKey("a")) {
            horizontalMovement -= speed;
        }

        if (Input.GetKey("d")) {
            horizontalMovement += speed;
        }

        this.transform.Translate(horizontalMovement * Time.deltaTime, 0, 0);

        // To crouch
        if (Input.GetKeyDown("s")) {
            this.transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        // To jump
        if (Input.GetKeyDown("w")) {
            this.transform.Translate(0, speedJump * Time.deltaTime, 0);
        }
    }
}
