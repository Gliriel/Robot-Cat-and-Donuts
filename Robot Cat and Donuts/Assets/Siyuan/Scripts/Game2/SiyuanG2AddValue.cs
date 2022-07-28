using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SiyuanG2AddValue : MonoBehaviour
{
    public int valueToGet;
    public int value = 0;
    public int valueToGetRed;
    public TextMeshProUGUI _valueToGetRed;
    public int valueToGetGreen;
    public TextMeshProUGUI _valueToGetGreen;
    

    
    void Start()
    {
        value = 0;

        valueToGetRed = Random.Range(1, 6);
        valueToGetGreen = Random.Range(0, 3);
        _valueToGetRed.text = valueToGetRed.ToString();
        _valueToGetGreen.text = valueToGetGreen.ToString();
        valueToGet = valueToGetRed + (valueToGetGreen * 10);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddValueShop(int valueGained)
    {
       value += valueGained;
    }
}
