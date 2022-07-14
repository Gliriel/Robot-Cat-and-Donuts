using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JenGame3WL : WinLose

{
    // Start is called before the first frame update
    void Start()
    {
        base.SetWin(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(base.win == true)
        {
            base.Win();
        }

        base.CheckWin();
    }
}
