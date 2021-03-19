using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RocketMovement : MonoBehaviour
{
    // SerializedField is a qualifier for a variable that makes it public in the Inspector
    [SerializeField] float Turnspeed = 100f;
    [SerializeField] float Thrustspeed = 100f;

    Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called every 0.02 sec
    void Update()
    {
        Thrust();
        Rotate();
    }

    private void Thrust()
    {
        float thrust = Thrustspeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            // We scale up our force by the thrust for the frame
            print("Thrusting");
            rigidBody.AddRelativeForce(Vector3.up * thrust * 10); // Extra times 10 for more thrust
        }
    }

    private void Rotate()
    {
        rigidBody.freezeRotation = true;
        float rotationThisFrame = Turnspeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("Rotating right");
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("Rotating left");
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }

        rigidBody.freezeRotation = false;
    }
}