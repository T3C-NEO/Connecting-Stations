using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Building : MonoBehaviour
{
    public GameObject track0;
    public GameObject track1;
    public GameObject track22;
    public GameObject track3;
    public GameObject track4;
    public GameObject track5;
    public GameObject track6;
    public GameObject track7;
    public GameObject track8;
    public GameObject track9;
    public GameObject track10;
    public GameObject track11;
    public GameObject track12;
    public GameObject track13;
    public GameObject track14;

    public GameObject test;

    Vector3 normScale = new Vector3(0.504899979f, 0.504899979f, 0.504899979f);

    Color none = new Color(0, 0, 0, 0);

    private Camera _mainCamera;
    public GameObject track;
    public GameObject track2;
    public TMP_Text moneyText;
    public int money = 300;

    public Color red = new Color(1, 0, 0, 1);

    public Color randomColor;
    public List<string> randomColorList = new List<string>();
    public string random;
    public Color pickedColor = new Color(0,0,0,0);

    public string ttag;


    public List<GameObject> spawnedTracks = new List<GameObject>();
 

    // Start is called before the first frame update
    void Awake()
    {
        _mainCamera = Camera.main;
        moneyText.text = "$"+money;
    }

    // Update is called once per frame
    void Update()
    {
    
        moneyText.text = "$"+money;
        var hit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        

        if (hit.collider)
        {
            if (hit.collider.gameObject.tag == "Verts" && Input.GetMouseButtonDown(0) && pickedColor != none)
            {
                money -= 25;
                moneyText.text = "$" + money;
                Instantiate(track, new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, -1), transform.rotation);
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.tag == "Horzs" && Input.GetMouseButtonDown(0) && pickedColor != none)
            {
                money -= 25;
                moneyText.text = "$" + money;
                Instantiate(track2, new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, -1), transform.rotation);
                Destroy(hit.collider.gameObject);
            }

            if (hit.collider.gameObject.layer == 3 && Input.GetMouseButtonDown(0))
            {
                pickedColor = hit.collider.gameObject.GetComponent<SpriteRenderer>().color;
                ttag = hit.collider.gameObject.tag;

                track0.transform.localScale = normScale;
                track1.transform.localScale = normScale;
                track22.transform.localScale = normScale;
                track3.transform.localScale = normScale;
                track4.transform.localScale = normScale;
                track5.transform.localScale = normScale;
                track6.transform.localScale = normScale;
                track7.transform.localScale = normScale;
                track8.transform.localScale = normScale;
                track9.transform.localScale = normScale;
                track10.transform.localScale = normScale;
                track11.transform.localScale = normScale;
                track12.transform.localScale = normScale;
                track13.transform.localScale = normScale;
                track14.transform.localScale = normScale;

                hit.collider.gameObject.transform.localScale = new Vector3(0.656369984f, 0.656369984f, 0.656369984f);
            }
            
        }
    }
}
