using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int velocity1;
    public int velocity2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(velocity1 * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, velocity2 * Time.deltaTime);
        }
        if (Input.GetKey("q"))
        {
            rb.AddForce(0, 0, velocity2 * Time.deltaTime);
        }
    }
}
