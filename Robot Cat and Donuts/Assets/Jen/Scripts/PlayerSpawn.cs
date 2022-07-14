using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform random;
    public int randNum;
    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(10, 48) * (Random.Range(0, 2) * 2 - 1);

        random.position = new Vector3(randNum, -5.2f, -0.1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
