using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    public float delay = 0.5f;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",delay,delay);
    }

    // Update is called once per frame
    void Spawn()
    {
        GameObject cune = Instantiate(cube,new Vector3(Random.Range(-7f,7f),9,0),Quaternion.identity);
    }
}
