using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DodgeInAir3 : MonoBehaviour
{
    public Rigidbody CatCube;
    public float DodgeSpeed = 0.05f;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        var keyboard = Keyboard.current;


        if (keyboard.aKey.IsPressed())
        {
            transform.Translate(Vector3.right * DodgeSpeed * Time.deltaTime);

            this.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (keyboard.dKey.IsPressed())
        {
            transform.Translate(Vector3.right * DodgeSpeed * Time.deltaTime);
            this.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }


    }
}
