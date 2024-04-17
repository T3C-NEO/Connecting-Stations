using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandColor : MonoBehaviour
{
    public Spawning build;
    public GameObject a;

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
}
