using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject track;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(laser, out hit) && Input.GetMouseButton(0))
        {
            Debug.Log("fhj");
            if (hit.collider)
            { 
                Instantiate(track, hit.rigidbody.position, transform.rotation);
            }
        }
    }
}
