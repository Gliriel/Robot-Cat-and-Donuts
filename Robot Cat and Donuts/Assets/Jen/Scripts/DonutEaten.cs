using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DonutEaten : MonoBehaviour
{
    Sprite _donut;
    public Sprite[] donuts;
    int currentImageIndex = 0;
    public WinLose winLose;
    SpriteRenderer _sr;

    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _donut = donuts[currentImageIndex];
        _sr.sprite = _donut;
    }

    private void Update()
    {
        if (currentImageIndex >= donuts.Length)
        {
            winLose.win = true;
        }
    }
    public void EatDonut()
    {
        
        currentImageIndex++;
        _donut = donuts[currentImageIndex];
        _sr.sprite = _donut;

        
    }
}
