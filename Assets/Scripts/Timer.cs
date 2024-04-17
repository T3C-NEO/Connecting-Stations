using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    int moneyTime;

    public Spawning scrip;
    public Building scrip2;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 10;
            moneyTime = 9;
            scrip2.money += (scrip.connectedStations.Count*10);
            scrip.SpawnStation();
            //timerText.color = Color.red;
        }

        if (remainingTime < moneyTime)
        {
            scrip2.money += (scrip.connectedStations.Count*10);
            moneyTime--;
        }

        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{00:00}:{01:00}", minutes, seconds);
    }
}
