using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public List<int> moneyTime = new List<int>();
    int moneyTime2;



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
            moneyTime2 = 9;
            scrip2.money += (scrip.connectedStations.Count*10);
            scrip.SpawnStation();
            moneyTime.Clear();
            for (int i = 0; i < scrip.connectedStations.Count; i++)
            {
                moneyTime.Add(GameObject.FindGameObjectsWithTag(scrip.connectedStations[i]).Length-2);
            }
            //timerText.color = Color.red;
        }

        if (remainingTime < moneyTime2)
        {
            for (int i = 0; i < moneyTime.Count; i++)
            {
                scrip2.money += 20/moneyTime[i];
            }
            moneyTime2--;
        }

        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{00:00}:{01:00}", minutes, seconds);
    }
}
