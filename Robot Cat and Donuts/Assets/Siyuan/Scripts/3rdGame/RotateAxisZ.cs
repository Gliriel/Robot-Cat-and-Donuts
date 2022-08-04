using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAxisZ : MonoBehaviour
{
    public float RotateSpeed = 0.1f;
    public int directionValue;
    void Start()
    { 
        RotateSpeed = Random.Range(0.1f, 0.25f);
        directionValue = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    { if (directionValue >= 1)
        { 
            transform.Rotate(Vector3.forward * RotateSpeed);
        }
        else
        {
            transform.Rotate(Vector3.back * RotateSpeed);
        }
        
    }
}
