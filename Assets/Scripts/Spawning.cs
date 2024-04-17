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

    public Color red = new Color(1, 0, 0, 1);

    public Color blue = new Color(0, 0.224f, 0.651f, 1);
    public Color orange = new Color(1, 0.388f, 0.098f, 1);
    public Color lightGreen = new Color(0.424f, 0.745f, 0.271f, 1);
    public Color brown = new Color(0.6f, 0.4f, 0.2f, 1);
    public Color gray = new Color(0.655f, 0.663f, 0.675f, 1);
    public Color yellow = new Color(0.988f, 0.8f, 0.039f, 1);
    public Color darkGray = new Color(0.502f, 0.506f, 0.514f, 1);
    public Color brightRed = new Color(0.933f, 0.208f, 0.18f, 1);
    public Color darkGreen = new Color(0, 0.576f, 0.235f, 1);
    public Color purple = new Color(0.725f, 0.2f, 0.678f, 1);

    public Color darkPurple = new Color(0.678f, 0.149f, 0.62f, 1);

    public Color darkBrown = new Color(0.431f, 0.196f, 0.098f, 1);
    public Color lightBrown = new Color(0.808f, 0.557f, 0, 1);

    public Color cyan = new Color(0, 0.631f, 0.871f, 1);

    public Color randomColor;
    public List<Color> ColorList = new List<Color>();
    
    public List<string> randomColorList = new List<string>();
    public string random;
    int randomInt;
    public Color pickedColor = new Color(0, 0, 0, 0);

    public List<string> connectingStations = new List<string>();
    public List<string> connectedStations = new List<string>();

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
     
    }
    private void Start()
    {
        ColorList.Add(blue);
        ColorList.Add(orange);
        ColorList.Add(lightGreen);
        ColorList.Add(brown);
        ColorList.Add(gray);
        ColorList.Add(yellow);
        ColorList.Add(darkGray);
        ColorList.Add(brightRed);
        ColorList.Add(darkGreen);
        ColorList.Add(purple);

        ColorList.Add(darkPurple);

        ColorList.Add(darkBrown);
        ColorList.Add(lightBrown);

        ColorList.Add(cyan);

        

        randomColorList.Add("blue");
        randomColorList.Add("orange");
        randomColorList.Add("light green");
        randomColorList.Add("brown");
        randomColorList.Add("gray");
        randomColorList.Add("yellow");
        randomColorList.Add("dark gray");
        randomColorList.Add("bright red");
        randomColorList.Add("dark green");
        randomColorList.Add("purple");
        //randomColorList.Add("strange green");
        randomColorList.Add("dark purple");
        //randomColorList.Add("dark gray2");
        randomColorList.Add("dark brown");
        randomColorList.Add("light brown");
        //randomColorList.Add("orange again");
        //randomColorList.Add("teal");
        //randomColorList.Add("more green");
        //randomColorList.Add("blue2");
        //randomColorList.Add("even more red");
        //randomColorList.Add("dark pink");
        randomColorList.Add("cyan");
        //randomColorList.Add("blue again again");
        //randomColorList.Add("gods more green");
        //randomColorList.Add("EVEN MORE RED");
        //randomColorList.Add("purple again");
        //randomColorList.Add("lighter orange");
    }

    public void SpawnStation()
    {
        //summoning stations when you press space. trying to get random colors to work
        randomInt = Random.Range(0, randomColorList.Count);
        random = randomColorList[randomInt];
        randomColor = ColorList[randomInt];

        int i = Random.Range(0, positsGame.Count);
        Instantiate(station, positsGame[i].transform.position, transform.rotation);
        positsGame.Remove(positsGame[i]);
        int j = Random.Range(0, positsGame.Count);
        Instantiate(station, positsGame[j].transform.position, transform.rotation);
        positsGame.Remove(positsGame[j]);
       
        picker[0].gameObject.SetActive(true);
        picker[0].color = randomColor;

        picker[0].tag = random;
        randomColorList.Remove(randomColorList[randomInt]);
        ColorList.Remove(ColorList[randomInt]);

        picker.Remove(picker[0]);

    }
}
