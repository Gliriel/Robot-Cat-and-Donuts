using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCat : MonoBehaviour
{
    public Transform targetObject;

    void Start()
    {
         
    }
       
    void FixedUpdate()
    {
      Vector3 pos = new Vector3(targetObject.position.x, transform.position.y, transform.position.z);
      transform.position = pos;
    }
}
