using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WInLoseCheckHelicopter : WinLose
{
    public BirdAccident bird_script;


    private void Start()
    {
        bird_script = GameObject.FindGameObjectWithTag("Cat").GetComponent<BirdAccident>();
        GameObject go = GameObject.Find("Battery");
        base.battery = go.GetComponent<Battery>();
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (_timer.stopTimer == true)
        {            
            base.Win();           
        }

        if (bird_script.birdG1 == true)
        {
            base.Lose();
        }
    }
}

