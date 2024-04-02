using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject station;

    public List<Vector3> posits = new List<Vector3>();

    //private Color colo;

    // Start is called before the first frame update
    void Awake ()
    {
        posits.Add(new Vector3(-3.5f,4,-1));
        posits.Add(new Vector3(-3.5f,2.5f,-1));
        posits.Add(new Vector3(-3.5f,1,-1));
        posits.Add(new Vector3(-3.5f,-0.5f,-1));
        posits.Add(new Vector3(-3.5f,-2f,-1));
        posits.Add(new Vector3(-3.5f,-3.5f,-1));

        posits.Add(new Vector3(-2f, 4, -1));
        posits.Add(new Vector3(-2f, 2.5f, -1));
        posits.Add(new Vector3(-2f, 1, -1));
        posits.Add(new Vector3(-2f, -0.5f, -1));
        posits.Add(new Vector3(-2f, -2f, -1));
        posits.Add(new Vector3(-2f, -3.5f, -1));

        posits.Add(new Vector3(-0.5f, 4, -1));
        posits.Add(new Vector3(-0.5f, 2.5f, -1));
        posits.Add(new Vector3(-0.5f, 1, -1));
        posits.Add(new Vector3(-0.5f, -0.5f, -1));
        posits.Add(new Vector3(-0.5f, -2f, -1));
        posits.Add(new Vector3(-0.5f, -3.5f, -1));

        posits.Add(new Vector3(1, 4, -1));
        posits.Add(new Vector3(1, 2.5f, -1));
        posits.Add(new Vector3(1, 1, -1));
        posits.Add(new Vector3(1, -0.5f, -1));
        posits.Add(new Vector3(1, -2f, -1));
        posits.Add(new Vector3(1, -3.5f, -1));

        posits.Add(new Vector3(2.5f, 4, -1));
        posits.Add(new Vector3(2.5f, 2.5f, -1));
        posits.Add(new Vector3(2.5f, 1, -1));
        posits.Add(new Vector3(2.5f, -0.5f, -1));
        posits.Add(new Vector3(2.5f, -2f, -1));
        posits.Add(new Vector3(2.5f, -3.5f, -1));

        posits.Add(new Vector3(4, 4, -1));
        posits.Add(new Vector3(4, 2.5f, -1));
        posits.Add(new Vector3(4, 1, -1));
        posits.Add(new Vector3(4, -0.5f, -1));
        posits.Add(new Vector3(4, -2f, -1));
        posits.Add(new Vector3(4, -3.5f, -1));
    }

    void Update()
    {
        //summoning stations when you press space. trying to get random colors to work
        if (Input.GetButtonDown("Jump"))
        {
            //colo = new Color(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256), 1);
            int i = Random.Range(0, posits.Count);
            Instantiate(station, posits[i], transform.rotation);
            //GetComponent<SpriteRenderer>().color = colo;
            posits.Remove(posits[i]);
            int j = Random.Range(0, posits.Count);
            Instantiate(station, posits[j], transform.rotation);
            //GetComponent<SpriteRenderer>().color = colo;
            posits.Remove(posits[j]);
        }

    }
}
