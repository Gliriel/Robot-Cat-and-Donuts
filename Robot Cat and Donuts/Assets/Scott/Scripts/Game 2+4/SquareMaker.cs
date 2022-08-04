using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMaker : MonoBehaviour
{
    public GameObject carble;
    public int randNum;
    public WinLose _winLose;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(8, 16); // this will return a number between 5 and 15 

        for (var i = 0; i < randNum; i++)
        {
            GameObject m = Instantiate(carble, new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), -0.05f), Quaternion.identity);
            var randScale = Random.Range(0.015f, 0.03f);
            m.transform.localScale = new Vector2(randScale, randScale);

        }
    }

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
