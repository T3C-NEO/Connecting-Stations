using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencySystem : MonoBehaviour
{
    pubic const string Money = "Money";

    public static int money = 0;
    // Start is called before the first frame update
    void Start()
    {
     	money = PlayerPrefs.GetInt("money");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpdateMoney()
    {
	PlayerPrefs.SetInt("Money", money);
	coins = PlayerPrefs.GetInt("Money");
	PlayerPrefs.Save();
    }
}
