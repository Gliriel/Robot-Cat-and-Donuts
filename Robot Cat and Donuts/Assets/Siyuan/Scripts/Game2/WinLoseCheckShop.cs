using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseCheckShop : WinLose
{
    public SiyuanG2AddValue siyuanG2;


    private void Start()
    {
        GameObject go = GameObject.Find("Battery");
        base.battery = go.GetComponent<Battery>();
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    private void Update()
    {
        if (_timer.stopTimer == true)
        {
            if (siyuanG2.valueToGet == siyuanG2.value)
            {
                base.Win();
            }
            else
            {
                base.Lose();
            }
        }
    }
}
