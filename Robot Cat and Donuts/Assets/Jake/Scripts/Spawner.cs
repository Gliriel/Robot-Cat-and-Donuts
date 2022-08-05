using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject objectToSpawn;
    public float spawnRate = 2.0f;
    

    void Start()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    private void Spawn()
    {
        Instantiate(objectToSpawn, RandomVectorXY() , Quaternion.identity);
    }
    
    Vector3 RandomVectorXY()
    {
        Vector3 randomVector = new Vector3(Random.Range(-0.80f, 0.80f), Random.Range(-0.80f, 0.80f), 0);
        return randomVector;
    }
}
