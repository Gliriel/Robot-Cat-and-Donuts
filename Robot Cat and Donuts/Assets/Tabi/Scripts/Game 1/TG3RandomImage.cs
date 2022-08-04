using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TG3RandomImage : MonoBehaviour
{
    public Image _imageB;
    public Sprite[] imageBs;
    public int currentImageBIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentImageBIndex = Random.Range(0, imageBs.Length);
        _imageB.sprite = imageBs[currentImageBIndex];
    }

    
}
