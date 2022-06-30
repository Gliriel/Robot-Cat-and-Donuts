using System;
using UnityEngine;


public class EventManager : MonoBehaviour
{

    public static EventManager Current;

    private void Awake()
    {
        Current = this;
    }

    public event Action OnWinConditionMet;

    public void WinConditionMet()
    {
        if (OnWinConditionMet != null)
        {
            OnWinConditionMet();
        }
    }

    public event Action OnTimerEnd;

    public void TimerEnd()
    {
        if (OnTimerEnd != null)
        {
            OnTimerEnd();
        }
    }

    
}
