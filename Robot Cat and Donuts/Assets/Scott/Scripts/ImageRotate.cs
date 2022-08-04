using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ImageRotate : MonoBehaviour
{
    public Image painting;
    public Sprite[] paintings;
    public int currentPaintingIndex;
    public float speed = 80;
    public Timer _timer;

    // Start is called before the first frame update
    void Start()
    {
        currentPaintingIndex = Random.Range(0, paintings.Length);
        painting.sprite = paintings[currentPaintingIndex];

    }

    private void Update()
    {
        
        var keyboard = Keyboard.current;
        if (_timer.stopTimer == false)
        {
            if (keyboard.aKey.IsPressed())
            {
                transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
            }
            else if (keyboard.dKey.IsPressed())
            {
                transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.forward * (speed / 2000));
            }
        }
    }
}
