using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackColor : MonoBehaviour
{
    public Building build;
    public GameObject a;

    public SpriteRenderer sprit;

    public bool connect = false;
    int connections = 2;

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

    void OnCollisionEnter2D(Collision2D col)
    {
    
        if (col.gameObject.tag == this.gameObject.tag)
        {
            connections--;
            if (connections == 0)
            {
                connect = true;
            }
        }
    }
}
