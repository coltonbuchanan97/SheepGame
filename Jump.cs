using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed;
    public float jumpPower;

    private Rigidbody2D rbody;
    private Collider2D collider;

    public bool grounded;
    public LayerMask whatIsTheGround;



    // Update is called once per frame
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        grounded = Physics2D.IsTouchingLayer(collider, whatIsTheGround);
        
        rbody.velocity = new Vector2(speed, rbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpPower);
        }
    }
}
