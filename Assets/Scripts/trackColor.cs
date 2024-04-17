using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackColor : MonoBehaviour
{
    public Building build;
    public GameObject a;

    public SpriteRenderer sprit;

    public bool connect = false;
    public bool station = false;
    public bool stationConnect = false;
    public int connections = 2;

    // Start is called before the first frame update
    void Awake()
    {
        a = GameObject.Find("grid");
        build = a.GetComponent<Building>();
        sprit = GetComponent<SpriteRenderer>();
        sprit.color = build.pickedColor;
        tag = build.ttag;

        //build.spawnedTracks.Add(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D col)
    {
    
        if (col.gameObject.tag == this.gameObject.tag)
        {
            if (col.gameObject.name == "Station(Clone)")
            {
                station = true;
                connections--;
                if (connections == 0)
                {
                    connect = true;
                }
            }
            if (col.gameObject.name != "Station(Clone)" && (col.gameObject.GetComponent<trackColor>().station == true || col.gameObject.GetComponent<trackColor>().stationConnect == true))
            {
                if (station == false)
                {
                    stationConnect = true;
                    connections--;
                    if (connections == 0)
                    {
                        connect = true;
                    }
                }   
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
    
        if (col.gameObject.tag != this.gameObject.tag && col.gameObject.name != this.gameObject.name)
        {
            build.money -= 10;
        }
    }
}
