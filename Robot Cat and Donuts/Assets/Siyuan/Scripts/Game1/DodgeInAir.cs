using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DodgeInAir : MonoBehaviour
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
            CatCube.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);

            this.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (keyboard.dKey.IsPressed())
        {
            CatCube.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
            this.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }


    }
}
