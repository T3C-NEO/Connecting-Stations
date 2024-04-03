using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Building : MonoBehaviour
{
    private Camera _mainCamera;
    public GameObject track;
    public GameObject track2;
    public TMP_Text moneyText;
    private int money = 300;
    bool placing = false;

    // Start is called before the first frame update
    void Awake()
    {
        _mainCamera = Camera.main;
        moneyText.text = "$"+money;
    }

    // Update is called once per frame
    void Update()
    {
        var hit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));

        //RaycastHit hit = new RaycastHit();
        if (Input.GetMouseButtonUp(0))
        {
            placing = false;
        }

        if (hit.collider && Input.GetMouseButtonDown(0))
        {
            if (hit.collider.gameObject.tag == "Red")
            {
                placing = true;
            }
        }

        if (hit.collider && placing == true)
        {
            if (hit.collider.gameObject.tag == "Verts")
            {
                money -= 25;
                moneyText.text = "$"+money;
                Instantiate(track, new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, -1), transform.rotation);
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.tag == "Horzs")
            {
                money -= 25;
                moneyText.text = "$"+money;
                Instantiate(track2, new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, -1), transform.rotation);
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
