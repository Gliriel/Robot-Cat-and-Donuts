using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{

    public float _time = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnOff());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator TurnOff()
    {
        yield return new WaitForSecondsRealtime(_time);
        this.gameObject.SetActive(false);
    }
}
