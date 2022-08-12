using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAccident : MonoBehaviour
{
    public bool birdG1 = false;
    public AudioSource audioSource;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            birdG1 = true;
            audioSource.Play();
            
        }
    }
}
