using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroyer : MonoBehaviour {
    /*
    // Runs when an object first enters into a collider zone
    // Runs once!
    void OnTriggerEnter2D(Collider2D other)
    {

    }

    // Runs whenever an object is inside a collider
    // Runs every frame
    void OnTriggerStay2D(Collider2D other)
    {

    }
    */

    // Runs whenever an object exits the collider zone
    // Runs once
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if (other.tag =="Floor")
        {
            Destroy(this.gameObject);
        }
    }
}
