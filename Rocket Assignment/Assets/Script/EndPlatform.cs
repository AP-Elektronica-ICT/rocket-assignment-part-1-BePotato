using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatform : MonoBehaviour
{
    public bool LandedOnPlatform = false;
  
    // Start is called before the first frame update
    void Start()
    {
        LandedOnPlatform = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LandedOnPlatform = true;
        }
    }
}
