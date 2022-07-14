using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpShop : MonoBehaviour
{
    public Rigidbody CatCube;
    public float forceAmount = 10;
  

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
        CatCube.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
        
        }

       if (Input.GetKey(KeyCode.D))
        {
        CatCube.AddForce(Vector3.down * forceAmount, ForceMode.Impulse);
        
        }
    }
}
