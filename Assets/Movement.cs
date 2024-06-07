using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float velocity = 3f;
    private float horizontal = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Horizontal"))
        {
            if(horizontal > 0f)
            {
                rb.velocity = new Vector2(rb.velocity.x + velocity, rb.velocity.y + velocity);
            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x - velocity, rb.velocity.y + velocity);
            }
            
        }
        
    }
}
