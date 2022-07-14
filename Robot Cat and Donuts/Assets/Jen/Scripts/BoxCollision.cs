using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    public WinLose winLose;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winLose.win = true;
    }
}
