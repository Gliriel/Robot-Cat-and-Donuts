using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JenGame2WL : WinLose
{

    public GameTwoAddValue gameTwoAddValue;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        GameObject go = GameObject.Find("Battery");
        base.battery = go.GetComponent<Battery>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer.stopTimer != false)
        {
            if (gameTwoAddValue.valueToGet == gameTwoAddValue.value)
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
