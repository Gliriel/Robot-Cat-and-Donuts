using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JakeGame1WL : WinLose
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Battery");
        base.battery = go.GetComponent<Battery>();
        base.SetWin(true);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (base.win == false)
        {
            base.Lose();
        }
        base.CheckWin();
    }
}
