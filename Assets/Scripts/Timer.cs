using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public List<GameObject> moneyTime = new List<GameObject>();
    int moneyTime2;



    public Spawning scrip;
    public Building scrip2;

    public timerTIme speed;

    public List<string> mates = new List<string>();
    public List<GameObject> mates2 = new List<GameObject>();


    public GameObject gameOver;
    public GameObject gameOverButt;
    public GameObject UI;


    void Start()
    {
        mates.Add("blue");
        mates.Add("orange");
        mates.Add("light green");
        mates.Add("brown");
        mates.Add("gray");
        mates.Add("yellow");
        mates.Add("dark gray");
        mates.Add("bright red");
        mates.Add("dark green");
        mates.Add("purple");
        //mates.Add("strange green");
        mates.Add("dark purple");
        //mates.Add("dark gray2");
        mates.Add("dark brown");
        mates.Add("light brown");
        //mates.Add("orange again");
        //mates.Add("teal");
        //mates.Add("more green");
        //mates.Add("blue2");
        //mates.Add("even more red");
        //mates.Add("dark pink");
        mates.Add("cyan");
        mates.Add("pale");
        mates.Add("pink");
    }
    void Update()
    {
              
        moneyTime.Clear();      
        for(int i = 0; i < scrip.connectedStations.Count; i++)
        {
            moneyTime.AddRange(GameObject.FindGameObjectsWithTag(scrip.connectedStations[i]));
        }
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            remainingTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{00}", seconds);
        }
        else if (remainingTime <= 0)
        {
            mates2.Clear();
            for (int i = 0; i < mates.Count; i++)
            {
                mates2.AddRange(GameObject.FindGameObjectsWithTag(mates[i]));
                mates2.RemoveAll(obj => obj.name == "Track 1(Clone)");
                mates2.RemoveAll(obj => obj.name == "Track 2(Clone)");
            }
            if (Mathf.RoundToInt(mates2.Count * 0.33f) > scrip.connectedStations.Count)
            {
                gameOver.SetActive(true);
                gameOverButt.SetActive(true);
                UI.SetActive(false);
            }
            else
            {

                //mates.AddRange( GameObject.FindGameObjectsWithTag( "mateTag"));
                remainingTime = 20 * GameObject.Find("TimerTime").GetComponent<timerTIme>().mod;
                moneyTime2 = 19;
                //scrip2.money += (scrip.connectedStations.Count * 20);
                scrip.SpawnStation();
                //timerText.color = Color.red;

            }
        }

        if (remainingTime < moneyTime2)
        {
            for (int i = 0; i < moneyTime.Count/3; i++)
            {
                scrip2.money += 5;
            }
            moneyTime2-=2;
        }
        
    }
}
