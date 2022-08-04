using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public TextMeshProUGUI winLoseText;
    public GameObject _panel;
    public bool win;
    public Timer _timer;
    public Battery battery;

    

       
    public void Win()
    {
        if(Time.timeScale > 0f)
        {
            StartCoroutine(WinState());
        }
    }

    public void Lose()
    {
        if (Time.timeScale > 0f)
        {
            StartCoroutine(LoseState());
        }
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

    public IEnumerator WinState()
    {
        _panel.SetActive(enabled);
        winLoseText.text = new string("YOU WIN");
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2f);
        battery.PlayedAGame();
        SceneManager.LoadScene(1);
    }

    public IEnumerator LoseState()
    {
        _panel.SetActive(enabled);
        winLoseText.text = new string("YOU LOSE");
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1f);
        battery.PlayedAGame();
        battery.DrainBattery();
        if (battery.currentBatteryIndex >= 3)
        {
            StartCoroutine(GameOver());
        }
        else
        {
            yield return new WaitForSecondsRealtime(1f);
            SceneManager.LoadScene(1);
        }
        

        
    }

    public IEnumerator GameOver()
    {
        winLoseText.text = new string("GAME OVER");
        yield return new WaitForSecondsRealtime(1f);
        Destroy(GameObject.FindGameObjectWithTag("Batt"));
        SceneManager.LoadScene(0);
    

    }

}
