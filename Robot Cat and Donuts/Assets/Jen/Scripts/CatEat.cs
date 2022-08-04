using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class CatEat : MonoBehaviour
{
    public bool MouthOpen;
    Sprite _cat;
    public Sprite[] Cats;
    public DonutEaten Donut;
    public int currentImageIndex;
    SpriteRenderer sr;

    private void Start()
    {
       sr = GetComponent<SpriteRenderer>();
        MouthOpen = false;
        currentImageIndex = 0;
        _cat = Cats[currentImageIndex];
        sr.sprite = _cat;
    }
    // Update is called once per frame
    void Update()
    {
           
        var keyboard = Keyboard.current;
        

        if (MouthOpen == false && keyboard.aKey.wasPressedThisFrame)
        {
            MouthOpen = true;
            currentImageIndex++;
            _cat = Cats[currentImageIndex];
            sr.sprite = _cat;
        }
        if (MouthOpen == true && keyboard.aKey.wasPressedThisFrame)
        {
            return;
        }
        if (MouthOpen == true && keyboard.dKey.wasPressedThisFrame)
        {
            MouthOpen = false;
            currentImageIndex--;
            _cat = Cats[currentImageIndex];
            sr.sprite = _cat;
            Donut.EatDonut();
        }
    }
}
