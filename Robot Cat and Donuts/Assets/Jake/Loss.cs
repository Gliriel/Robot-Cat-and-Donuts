
using UnityEngine;

public class Loss : MonoBehaviour
{
    public WinLose winLose;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Cat"))
        {
            Debug.Log($"Game Over{col}");
            winLose.win = false;
        }
    }
}
