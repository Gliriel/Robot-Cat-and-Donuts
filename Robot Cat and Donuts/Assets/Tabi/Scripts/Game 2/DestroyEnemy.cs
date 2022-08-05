using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D col)
    {

      if(col.gameObject.tag == "Destroyer"){

        Destroy(this.gameObject); //not working
      }
   }
}
