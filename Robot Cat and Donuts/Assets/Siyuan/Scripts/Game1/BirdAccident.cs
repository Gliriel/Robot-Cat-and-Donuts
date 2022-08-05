using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAccident : MonoBehaviour
{
    public bool birdG1 = false;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            birdG1 = true;
            
        }
    }
}
