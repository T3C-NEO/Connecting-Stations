using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandColor : MonoBehaviour
{
    public Spawning build;
    public GameObject a;

    public bool connected = false;

    public SpriteRenderer sprit;
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("grid");
        build = a.GetComponent<Spawning>();
        sprit = GetComponent<SpriteRenderer>();
        sprit.color = build.randomColor;
        tag = build.random;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay2D(Collision2D col)
    {
    
        if (col.gameObject.tag == this.gameObject.tag && col.gameObject.GetComponent<trackColor>().connect == true)
        {
            Destroy(this.gameObject.GetComponent<BoxCollider2D>());
            if (build.connectingStations.Contains(tag))
            {
                connected = true;
                build.connectedStations.Add(tag);

            }else
            {
                build.connectingStations.Add(tag);
            }
        }
    }
}
