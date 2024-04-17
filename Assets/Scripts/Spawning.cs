using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject station;

    public List<Vector3> posits = new List<Vector3>();
    public List<GameObject> positsGame = new List<GameObject>();
    public List<SpriteRenderer> picker = new List<SpriteRenderer>();

    public GameObject pos0;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;
    public GameObject pos7;
    public GameObject pos8;
    public GameObject pos9;
    public GameObject pos10;
    public GameObject pos11;
    public GameObject pos12;
    public GameObject pos13;
    public GameObject pos14;
    public GameObject pos15;
    public GameObject pos16;
    public GameObject pos17;
    public GameObject pos18;
    public GameObject pos19;
    public GameObject pos20;
    public GameObject pos21;
    public GameObject pos22;
    public GameObject pos23;
    public GameObject pos24;
    public GameObject pos25;
    public GameObject pos26;
    public GameObject pos27;
    public GameObject pos28;
    public GameObject pos29;
    public GameObject pos30;
    public GameObject pos31;
    public GameObject pos32;
    public GameObject pos33;
    public GameObject pos34;
    public GameObject pos35;

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


        positsGame.Add(pos0);
        positsGame.Add(pos1);
        positsGame.Add(pos2);
        positsGame.Add(pos3);
        positsGame.Add(pos4);
        positsGame.Add(pos5);
        positsGame.Add(pos6);
        positsGame.Add(pos7);
        positsGame.Add(pos8);
        positsGame.Add(pos9);
        positsGame.Add(pos10);
        positsGame.Add(pos11);
        positsGame.Add(pos12);
        positsGame.Add(pos13);
        positsGame.Add(pos14);
        positsGame.Add(pos15);
        positsGame.Add(pos16);
        positsGame.Add(pos17);
        positsGame.Add(pos18);
        positsGame.Add(pos19);
        positsGame.Add(pos20);
        positsGame.Add(pos21);
        positsGame.Add(pos22);
        positsGame.Add(pos23);
        positsGame.Add(pos24);
        positsGame.Add(pos25);
        positsGame.Add(pos26);
        positsGame.Add(pos27);
        positsGame.Add(pos28);
        positsGame.Add(pos29);
        positsGame.Add(pos30);
        positsGame.Add(pos31);
        positsGame.Add(pos32);
        positsGame.Add(pos33);
        positsGame.Add(pos34);
        positsGame.Add(pos35);
        /*
        posits.add(new vector3(-3.5f,4,-1));
        posits.add(new vector3(-3.5f,2.5f,-1));
        posits.add(new vector3(-3.5f,1,-1));
        posits.add(new vector3(-3.5f,-0.5f,-1));
        posits.add(new vector3(-3.5f,-2f,-1));
        posits.add(new vector3(-3.5f,-3.5f,-1));

        posits.add(new vector3(-2f, 4, -1));
        posits.add(new vector3(-2f, 2.5f, -1));
        posits.add(new vector3(-2f, 1, -1));
        posits.add(new vector3(-2f, -0.5f, -1));
        posits.add(new vector3(-2f, -2f, -1));
        posits.add(new vector3(-2f, -3.5f, -1));

        posits.add(new vector3(-0.5f, 4, -1));
        posits.add(new vector3(-0.5f, 2.5f, -1));
        posits.add(new vector3(-0.5f, 1, -1));
        posits.add(new vector3(-0.5f, -0.5f, -1));
        posits.add(new vector3(-0.5f, -2f, -1));
        posits.add(new vector3(-0.5f, -3.5f, -1));

        posits.add(new vector3(1, 4, -1));
        posits.add(new vector3(1, 2.5f, -1));
        posits.add(new vector3(1, 1, -1));
        posits.add(new vector3(1, -0.5f, -1));
        posits.add(new vector3(1, -2f, -1));
        posits.add(new vector3(1, -3.5f, -1));

        posits.add(new vector3(2.5f, 4, -1));
        posits.add(new vector3(2.5f, 2.5f, -1));
        posits.add(new vector3(2.5f, 1, -1));
        posits.add(new vector3(2.5f, -0.5f, -1));
        posits.add(new vector3(2.5f, -2f, -1));
        posits.add(new vector3(2.5f, -3.5f, -1));

        posits.add(new vector3(4, 4, -1));
        posits.add(new vector3(4, 2.5f, -1));
        posits.add(new vector3(4, 1, -1));
        posits.add(new vector3(4, -0.5f, -1));
        posits.add(new vector3(4, -2f, -1));
        posits.add(new vector3(4, -3.5f, -1));
        */
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //SpawnStation();
        }
    }
    public void SpawnStation()
    {
        //summoning stations when you press space. trying to get random colors to work
        build.random = build.randomColorList[Random.Range(0, build.randomColorList.Count)];
        if (build.random == "red")
        {
            build.randomColor = red;
        }

        int i = Random.Range(0, positsGame.Count);
       Instantiate(station, positsGame[i].transform.position, transform.rotation);
       positsGame.Remove(positsGame[i]);
       int j = Random.Range(0, positsGame.Count);
       Instantiate(station, positsGame[j].transform.position, transform.rotation);
       positsGame.Remove(positsGame[j]);
       
       picker[0].gameObject.SetActive(true);
       picker[0].color = build.randomColor;
       build.randomColorList.Remove(build.random);
       picker.Remove(picker[0]);

    }
}
