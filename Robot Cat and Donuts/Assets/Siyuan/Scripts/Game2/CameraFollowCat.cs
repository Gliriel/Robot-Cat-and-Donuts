using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCat : MonoBehaviour
{
    public Transform targetObject;

    public float SmoothTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 pos = new Vector3(targetObject.position.x - 1.2f, transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, SmoothTime);
    }
}
