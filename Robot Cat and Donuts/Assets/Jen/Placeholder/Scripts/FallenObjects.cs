using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObjects : MonoBehaviour
{
    public float delay = 0.1f;
    public GameObject sphere;

    void Start()
    {
        InvokeRepeating("Spawn",delay,delay);
    }

    void Spawn ()
    {
        Instantiate(sphere,new Vector3(Random.Range(-6,6),10,0),Quaternion.identity);
    }


}
