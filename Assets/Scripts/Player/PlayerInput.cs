using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    float horizontalInput = 0f;
    float verticalInput = 0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        // Move the player based on the input values
        rb.MovePosition(rb.position + new Vector2(horizontalInput, verticalInput) * Time.fixedDeltaTime);
    }

    void Move()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");


    }
}
