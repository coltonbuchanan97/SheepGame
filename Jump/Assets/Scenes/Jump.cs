using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed;
    public float jumpPower;

    private Rigidbody2D rbody;

    // Update is called once per frame
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rbody.velocity = new Vector2(speed, rbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpPower);
        }
    }
}
