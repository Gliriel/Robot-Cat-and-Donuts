using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    public AudioSource _cs;

    public AudioClip[] audioClip;

  
    public void PlayRandomSoundBite()
    {
        
            _cs.clip = audioClip[Random.Range(0, audioClip.Length)];
            _cs.PlayOneShot (_cs.clip);
        
    }
}
