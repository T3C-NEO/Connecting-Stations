using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InputHandler : MonoBehaviour
{
    #region Variables
    
    public GameObject track; 
    public GameObject track2; 
    public TMP_Text moneyText;
    private int money = 300;

    private Camera _mainCamera;

    #endregion

    private void Awake()
    {
        _mainCamera = Camera.main;
    }
    private void Start()
    {
        moneyText.text = "$"+money;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

        Debug.Log(rayHit.collider.gameObject.name);
        if (rayHit.collider.gameObject.tag == "Verts")
        {
            money -= 25;
            moneyText.text = "$"+money;
            Instantiate(track, new Vector3(rayHit.collider.gameObject.transform.position.x, rayHit.collider.gameObject.transform.position.y, -1), transform.rotation);
        }
        if (rayHit.collider.gameObject.tag == "Horzs")
        {
            money -= 25;
            moneyText.text = "$"+money;
            Instantiate(track2, new Vector3(rayHit.collider.gameObject.transform.position.x, rayHit.collider.gameObject.transform.position.y, -1), transform.rotation);
        }
    }
}