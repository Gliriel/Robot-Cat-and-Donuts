using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timer;
    public float gameTime;
    [HeaderAttribute("Animation Curve")]
    public AnimationCurve animationCurve;
    public float graphValue;

    public bool stopTimer;

    private void Start()
    {
        stopTimer = false;
        timer.maxValue = gameTime;
        timer.value = graphValue;
    }

    private void Update()
    {
        float time = gameTime - Time.time;

        if (time <= 0)
        {
            stopTimer = true;
        }

        if (stopTimer == false)
        {
            timer.value = graphValue;
        }
    }

    private void FixedUpdate()
    {
        graphValue = animationCurve.Evaluate(Time.time);
    }
}
