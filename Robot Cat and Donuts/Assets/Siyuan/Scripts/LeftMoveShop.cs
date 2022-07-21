using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMoveShop : MonoBehaviour
{
    public float speed = 2;
    void Start()
    {
       
    
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
