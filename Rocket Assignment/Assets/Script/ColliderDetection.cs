using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "LaunchPlatform")
        {
            print("Collision with Launchplatform");
        }

        if (collision.gameObject.name == "EndPlatform")
        {
            print("Collision with EndPlatform");
        }

        if (collision.gameObject.name == "Floor")
        {
            print("Collision with Floor");
        }
    }
}
