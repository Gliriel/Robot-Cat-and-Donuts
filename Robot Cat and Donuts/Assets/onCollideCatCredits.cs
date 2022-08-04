using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class onCollideCatCredits : MonoBehaviour
{
    public TextMeshProUGUI text;
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
        if (Keyboard.current.aKey.isPressed)
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
            text.enabled = true;
            Debug.Log("colliding");
        }
    }
}
