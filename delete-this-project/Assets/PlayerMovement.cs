﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int velocity1;
    public int velocity2;
    public int jump;


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
        
    }
    void OnColissionEnter(Collision Collidername)
    {
        if (Collidername.collider.tag == "Terrain" && Input.GetKey("space"))
        {
            rb.AddForce(0, jump * Time.deltaTime, 0);
        }
    }
}
