using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberList : MonoBehaviour
{
    public List<int> PlayedNumbers;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
