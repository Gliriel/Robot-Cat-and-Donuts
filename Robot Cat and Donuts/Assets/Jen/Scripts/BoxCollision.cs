using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    public WinLose winLose;
    public PlayRandomSound _playSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _playSound.PlayRandomSoundBite();
        winLose.win = true;
    }
}
