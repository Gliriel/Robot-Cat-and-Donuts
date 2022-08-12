using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScottGame4WL : WinLose
{

    public AudioSource audioSource;
    void Start()
    {

        GameObject go = GameObject.Find("Battery");
        base.battery = go.GetComponent<Battery>();
        base.SetWin(false);
        Time.timeScale = 1f;

    }


    void Update()
    {
        if (base.win == true)
        {
            base.Win();
            audioSource.Pause();
        }
        base.CheckWin();
    }
}
