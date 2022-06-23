using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleMaker : MonoBehaviour
{

    public GameObject carble;


    // Start is called before the first frame update
    void Start()
    {
        var randNum = Random.Range(5, 15); // this will return a number between 0 and 9 

        for (var i = 0; i < randNum; i++)
        {
            GameObject m = Instantiate(carble, new Vector3(Random.Range(-0.1f,0.1f), Random.Range(-0.1f, 0.1f), -0.05f), Quaternion.identity);
            var randScale = Random.Range(0.01f, 0.035f);
            m.transform.localScale = new Vector2(randScale,randScale);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
