using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JenGame1WL : WinLose
{
    // Start is called before the first frame update
    void Start()
    {
        base.SetWin(true);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (base.win == false)
        {
            base.Lose();
        }
        base.CheckWin();
    }
}
