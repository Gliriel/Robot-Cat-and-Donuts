using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class onCollideCatStart : MonoBehaviour
{
    public Sprite keyUp;
    public Sprite keyDown;
    private Image img;

    void Awake()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            img.sprite = keyDown;
        }
        else
        {
            img.sprite = keyUp;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cat"))
        {
            Debug.Log("Collision with cat");
            SceneManager.LoadScene(1);
        }
    }
}
