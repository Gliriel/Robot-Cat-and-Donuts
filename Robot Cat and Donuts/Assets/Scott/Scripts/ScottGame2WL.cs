using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScottGame2WL : WinLose
{
    
    
    void Start()
    {
        base.SetWin(false);
        Time.timeScale = 1f;
    }

    
    void Update()
    {
        if (base.win == true)
        {
            base.Win();
        }
        base.CheckWin();
    }
}
