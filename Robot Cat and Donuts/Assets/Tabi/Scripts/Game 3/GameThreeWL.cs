using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameThreeWL : WinLose
{
    // Start is called before the first frame update
    void Start()
    {
        base.SetWin(true);

        Time.timeScale = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(base.win != true)
        {
            base.Lose();
        }
        base.CheckWin();
    }
}
