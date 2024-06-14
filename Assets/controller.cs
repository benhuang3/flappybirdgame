
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;
    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
                Debug.Log("PlayerController started and Rigidbody2D component found.");
    }

    void Update()
    {


        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            rb.velocity = new Vector2(0, 8);
            Debug.Log(isGrounded);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
{
        if (IsGroundLayer(collision.gameObject))
        {
            isGrounded = true;
            // Debug.Log("Collision detected with " + collision.gameObject.name);
            // Debug.Log("Is Ground Layer: " +IsGroundLayer(collision.gameObject));
            // Debug.Log("" );


        }
}

    void OnCollisionStay2D(Collision2D collision)
{
        if (IsGroundLayer(collision.gameObject))
        {
            isGrounded = true;
            // Debug.Log("Collision detected with " + collision.gameObject.name);
            // Debug.Log("Is Ground Layer: " +IsGroundLayer(collision.gameObject));
            // Debug.Log("" );


        }
}
    void OnCollisionExit2D(Collision2D collision)
    {
        // Debug.Log("Collision ended with " + collision.gameObject.name);
        // Debug.Log("Is Ground Layer: " +IsGroundLayer(collision.gameObject));
        //             Debug.Log("" );

        if (IsGroundLayer(collision.gameObject))
        {
            isGrounded = false;
            
        }
    }
    private bool IsGroundLayer(GameObject obj)
    {
        
        return (obj.layer == LayerMask.NameToLayer("GroundLayer"));
    }
}
