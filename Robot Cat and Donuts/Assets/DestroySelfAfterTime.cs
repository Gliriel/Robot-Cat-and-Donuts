using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfAfterTime : MonoBehaviour
{
    public AudioSource _audio;
    private bool played;
    // Start is called before the first frame update
    void Start()
    {
        played = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestorySelf()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(this.gameObject);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (!played)
        {
           _audio.Play();
           played = true;
        } else if (collision.gameObject.CompareTag("Cat"))
        {
            StartCoroutine("DestorySelf");
        }
    }
}
