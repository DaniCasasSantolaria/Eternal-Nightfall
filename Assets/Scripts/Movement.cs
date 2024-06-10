using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float velocity = 200f;
    Vector2 move;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ControlMovement();
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Flip();
    }

    private void ControlMovement()
    {
        rb.velocity = new Vector2(move.x * velocity * Time.deltaTime, move.y * velocity * Time.deltaTime);
    }

    private void Flip()
    {
        if(move.x > 0f && transform.localScale.x < 0f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(move.x < 0f && transform.localScale.x > 0f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
