using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateBox : MonoBehaviour
{
    public float speed = 4;

    private void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard.aKey.IsPressed())
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }
        if (keyboard.dKey.IsPressed())
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
    }        
}
