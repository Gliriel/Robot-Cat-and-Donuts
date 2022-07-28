using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCounter : MonoBehaviour
{
    public int valueGreen = 10;
    public int valueRed = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GreenOrb")
        {
            GetComponent<SiyuanG2AddValue>().AddValueShop(valueGreen);
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "RedOrb")
        {
            GetComponent<SiyuanG2AddValue>().AddValueShop(valueRed);
            Destroy(collision.gameObject);

        }
    }

}
