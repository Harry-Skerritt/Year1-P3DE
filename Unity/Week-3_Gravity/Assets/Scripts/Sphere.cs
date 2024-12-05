using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Runs when a collision is detected
    void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        Debug.Log(name);
        if (collision.gameObject.name == "Obstacle_2")
        {
            Debug.Log("Touched Bottom Bumper");
        }
    }
}
