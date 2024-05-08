using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerTIme : MonoBehaviour
{
    public float mod = 1;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
