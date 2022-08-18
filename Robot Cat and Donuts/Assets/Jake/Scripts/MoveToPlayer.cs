using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public float speed;
    public Timer timer;
    private Transform target;
    public float finalSpeed;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
       
        
        transform.position = Vector2.MoveTowards(transform.position, target.position, finalSpeed  * Time.deltaTime);
        
     
    }

    private void FixedUpdate()
    {
        if (timer.graphValue >= 1)
        {
            finalSpeed = (speed * (1 / timer.graphValue));
        }
        else
        {
            finalSpeed = speed;
        }
    }
}
