using System;
using UnityEngine;


public class EventManager : MonoBehaviour
{

    public static EventManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public event Action OnWinConditionMet;

    public void WinConditionMet()
    {
        OnWinConditionMet?.Invoke();
    }

    public event Action OnTimerEnd;

    public void TimerEnd()
    {
        OnTimerEnd?.Invoke();
    }
}
