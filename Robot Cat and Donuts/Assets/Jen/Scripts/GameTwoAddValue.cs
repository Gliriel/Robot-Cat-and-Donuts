using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTwoAddValue : MonoBehaviour
{
    public int valueToGet;
    public int value = 0;
    public TextMeshProUGUI _valuetoGet;
    public TextMeshProUGUI _value;


    // Start is called before the first frame update
    void Start()
    {
        value = 0;
        valueToGet = Random.Range(-3, 10);
        _valuetoGet.text = valueToGet.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddValue (int valueGained)
    {
        value += valueGained;
        _value.text = value.ToString();
    }
}
