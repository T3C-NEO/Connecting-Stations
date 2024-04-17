using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour
{
    public int count;
    public Text text;

    void Start()
    {
        count = PlayerPrefs.GetInt("amount");
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            count += 25;
            PlayerPrefs.SetInt("amount", count);
            
        }

        text.text = "" + count;

    }
}
