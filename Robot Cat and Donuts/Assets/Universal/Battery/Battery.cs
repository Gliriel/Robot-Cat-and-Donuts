using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public Image _battery;
    public Sprite[] batteries;
    public int currentBatteryIndex = 0;
    public int gamesPlayed;
    

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        _battery = GetComponentInChildren<Image>();
        _battery.sprite = batteries[currentBatteryIndex];
        
    }

    public void DrainBattery()
    {
        currentBatteryIndex++;
        _battery.sprite = batteries[currentBatteryIndex];
    }

    public void PlayedAGame()
    {
        gamesPlayed++;
    }
}
