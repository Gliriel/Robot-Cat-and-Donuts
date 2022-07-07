using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObjects : MonoBehaviour
{
    public float delay = 0.08f;
    public GameObject sphere;

    void Start()
    {
        InvokeRepeating("Spawn",delay,delay);
    }

    void Spawn ()
    {
        GameObject cuke = Instantiate(sphere,new Vector3(Random.Range(-7f,7f),10,0),Quaternion.identity);
        var randScale = Random.Range(0.5f, 1.2f);
        cuke.transform.localScale = new Vector2(randScale, randScale);
    }


}
