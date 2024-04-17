using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    public Spawning build;
    int del = 2;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerExit2D(Collider2D col)
    {
        del--;
        if (del == 0)
        {
            //int.TryParse(gameObject.name, out i);
            build.positsGame.Remove(this.gameObject);
            //Destroy(this.gameObject);
        }
    }
}
