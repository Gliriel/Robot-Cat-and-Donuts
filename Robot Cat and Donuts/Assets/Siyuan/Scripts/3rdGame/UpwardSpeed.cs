using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardSpeed : MonoBehaviour
{
    public float speed = 2;
    public Rigidbody CatCube;
    //public float forceAmount = 10;
    void Start()
    {
        //CatCube.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
