using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenNumber : MonoBehaviour
{
    public float delay = 0.08f;
    public GameObject[] numbers;

    void Start()
    {
        InvokeRepeating("Spawn",delay,delay);
    }

    void Spawn ()
    {
        Instantiate( numbers[Random.Range(0, numbers.Length)] ,new Vector3(Random.Range(-7f,7f),10,0),Quaternion.identity);
        
    }


}
