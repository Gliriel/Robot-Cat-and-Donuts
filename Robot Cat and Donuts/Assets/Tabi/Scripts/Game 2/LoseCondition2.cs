using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition2 : MonoBehaviour
{
    public WinLose winLose;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            winLose.win = false;
        }
    }
}
