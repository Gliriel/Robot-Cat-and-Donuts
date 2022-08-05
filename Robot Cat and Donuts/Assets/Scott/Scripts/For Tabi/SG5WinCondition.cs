using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SG5WinCondition : WinLose
{

    public TG3RandomImage TG3RI;
    public TG3ScrollImage TG3SI;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(_timer.stopTimer != false)
        {
            if(TG3SI.currentImageAIndex == TG3RI.currentImageBIndex)
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
