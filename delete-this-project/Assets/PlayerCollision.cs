using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement script;
    void OnCollisionEnter (Collision colliderinfo)
    {
        if (colliderinfo.collider.tag == "Obstacle")
        {
            Debug.Log("we hit an  obsticle");
            script.enabled = false;

        }
        
    }
}
