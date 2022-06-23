using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 4f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speed * Time.deltaTime;
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
