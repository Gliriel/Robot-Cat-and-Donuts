using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public WinLose winLose;
    void Start()
    {
        GameObject go = GameObject.Find("Battery");
        base.battery = go.GetComponent<Battery>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            winLose.win = false;

        }
    }
}