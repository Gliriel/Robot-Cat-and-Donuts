using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleMaker : MonoBehaviour
{

    public GameObject carble;
    public int randNum;
    public WinLose _winLose;


    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(5, 15); // this will return a number between 5 and 15 

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
        if (randNum == 0)
        {
            _winLose.win = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        randNum -= 1;
        Destroy(collision.gameObject);
    }
}
