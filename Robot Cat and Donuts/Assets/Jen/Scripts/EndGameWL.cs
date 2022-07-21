using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameWL : WinLose
{
    // Start is called before the first frame update
    void Start()
    {
        base.SetWin(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (base.win == true)
        {
            base.Win();
        }
        base.CheckWin();
    }
}
