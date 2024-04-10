using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject station;

    public List<Vector3> posits = new List<Vector3>();
    public List<SpriteRenderer> picker = new List<SpriteRenderer>();

    public SpriteRenderer track0;
    public SpriteRenderer track1;
    public SpriteRenderer track2;
    public SpriteRenderer track3;
    public SpriteRenderer track4;
    public SpriteRenderer track5;
    public SpriteRenderer track6;
    public SpriteRenderer track7;
    public SpriteRenderer track8;
    public SpriteRenderer track9;
    public SpriteRenderer track10;
    public SpriteRenderer track11;


    public Building build;

    void Awake ()
    {
        picker.Add(track0);
        picker.Add(track1);
        picker.Add(track2);
        picker.Add(track3);
        picker.Add(track4);
        picker.Add(track5);
        picker.Add(track6);
        picker.Add(track7);
        picker.Add(track8);
        picker.Add(track9);
        picker.Add(track10);
        picker.Add(track11);


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

            picker[0].gameObject.SetActive(true);
            picker[0].color = build.randomColor;
            picker.Remove(picker[0]);
        }

    }
}
