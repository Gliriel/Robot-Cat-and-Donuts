
using UnityEngine;

public class Loss : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Cat"))
        {
            Debug.Log($"Game Over{col}");
        }
    }
}
