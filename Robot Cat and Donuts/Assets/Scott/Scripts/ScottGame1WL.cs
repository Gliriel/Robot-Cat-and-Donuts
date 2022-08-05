using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScottGame1WL : WinLose
{
    public ImageRotate imageRotate;

    void Start()
    {

        GameObject go = GameObject.Find("Battery");
        base.battery = go.GetComponent<Battery>();
        Time.timeScale = 1f;

    }

    void Update()
    {
        if (_timer.stopTimer != false)
        {
            if (imageRotate.painting.transform.localEulerAngles.z <= 2f || imageRotate.painting.transform.localEulerAngles.z >= 358f)
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
