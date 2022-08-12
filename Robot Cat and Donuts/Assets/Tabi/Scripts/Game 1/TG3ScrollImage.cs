using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TG3ScrollImage : MonoBehaviour
{
    public Image _imageA;
    public Sprite[] imageAs;
    public int currentImageAIndex;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        currentImageAIndex = Random.Range(0, imageAs.Length);
        _imageA.sprite = imageAs[currentImageAIndex];
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard.aKey.wasPressedThisFrame)
        {
            currentImageAIndex--;
            if (currentImageAIndex < 0)
            {
                currentImageAIndex = imageAs.Length;
            }
            _imageA.sprite = imageAs[currentImageAIndex];
            playSound();
        }
        if (keyboard.dKey.wasPressedThisFrame)
        {
            currentImageAIndex++;
            if (currentImageAIndex > imageAs.Length)
            {
                currentImageAIndex = 0;
            }
            _imageA.sprite = imageAs[currentImageAIndex];
            playSound();
        }
    }

    void playSound()
    {
        audioSource.Play();
    }
}
