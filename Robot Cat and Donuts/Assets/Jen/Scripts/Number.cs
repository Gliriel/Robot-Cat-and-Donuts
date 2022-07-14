using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
  public int value = 1;

  private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<GameTwoAddValue>().AddValue(value);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }

    }
}
