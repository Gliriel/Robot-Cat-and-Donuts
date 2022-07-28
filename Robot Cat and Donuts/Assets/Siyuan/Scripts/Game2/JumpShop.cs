using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

        var keyboard = Keyboard.current;

        
        if (keyboard.aKey.IsPressed())
        {
        CatCube.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
        
        }

       if (keyboard.dKey.IsPressed())
        {
        CatCube.AddForce(Vector3.down * forceAmount, ForceMode.Impulse);
        
        }

        
    }
}
