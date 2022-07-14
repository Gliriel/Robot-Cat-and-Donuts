using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinLose : MonoBehaviour
{
    public TextMeshProUGUI winLoseText;
    public GameObject _panel;
    public bool win;
    public Timer _timer;
    
    public void Win()
    {
        _panel.SetActive(enabled);
        winLoseText.text = new string("YOU WIN");
        Time.timeScale = 0f;
    }

    public void Lose()
    {
        _panel.SetActive(enabled);
        winLoseText.text = new string("YOU LOSE");
        Time.timeScale = 0f;
    }

    public virtual void SetWin(bool _bool)
    {
        win = _bool;
    }

    public virtual void CheckWin()
    {
        if (_timer.stopTimer == true && win != false)
        {
            Win();
        }
        if (_timer.stopTimer == true && win == false)
        {
            Lose();
        }
    }

}
