using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    public float speed = 10f;
    public float jumpForce = 100f;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal
        float x = Input.GetAxis("Horizontal");
        rigidbody.AddForce(new Vector2(x * speed, 0));

        // Salto
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(new Vector2(0, jumpForce));
        }

    }
}
