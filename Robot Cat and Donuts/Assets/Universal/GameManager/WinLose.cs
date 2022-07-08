using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinLose : MonoBehaviour
{
    public TextMeshProUGUI winLoseText;
    public GameObject _panel;
    private bool win;
    private Timer _timer;
    

    // Start is called before the first frame update
    public void Start()
    {
        SetWin();
        _timer = GetComponent<Timer>(); 
    }

    // Update is called once per frame
    public void Update()
    {
        CheckWin();
    }

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

    public virtual void SetWin()
    {
        win = false;
    }

    public virtual void CheckWin()
    {
        if (win != false)
        {
            Win();
        }
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
