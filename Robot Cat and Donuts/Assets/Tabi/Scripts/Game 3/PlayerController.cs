using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public int jumpForce = 100;

    
    private Vector2 velocity;
    private float moveX;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
  
        
        velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (rb.velocity.y < 0)
        {
            Debug.Log("Collided");
            if (collision.collider.CompareTag("Platform"))
            {
               
                velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }
}
