using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObjectsR2 : MonoBehaviour
{
    public float delay = 0.08f;
    public GameObject sphere;

    void Start()
    {
        InvokeRepeating("Spawn",delay,delay);
    }

    void Spawn ()
    {
        GameObject cuke = Instantiate(sphere,new Vector3(Random.Range(-6f,6f),7,0),Quaternion.identity);
        var randScale = Random.Range(0.2f, 0.5f);
        cuke.transform.localScale = new Vector2(randScale, randScale);
    }


}
