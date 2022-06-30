using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    float xspawn = 10;
    public float ymin = 0.6f;
    public float ymax = 100f;
        
    public int platformCount = 300;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(ymin, ymax);
            spawnPosition.x = Random.Range(xspawn * -1, xspawn);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

}
