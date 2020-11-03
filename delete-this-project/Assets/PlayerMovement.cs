using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int velocity1;
    public int velocity2;
    public float RayDistance = 1f;
   
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, RayDistance);
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, velocity1 * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(velocity2 * Time.deltaTime, 0,0 ,ForceMode.VelocityChange);
        }
        if (Input.GetKey("q"))

        {
            rb.AddForce(-velocity2 * Time.deltaTime, 0, 0,ForceMode.VelocityChange );
        }
        if (Input.GetKey("space") && IsGrounded( ))
        {
            rb.AddForce(0, 46, 0);
        }
    }
    
}
