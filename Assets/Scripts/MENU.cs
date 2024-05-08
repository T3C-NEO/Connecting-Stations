using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    public GameObject rules;
    public GameObject rulesText;
    public GameObject play;
    public GameObject rule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowRules()
    {
        rules.SetActive(true);
        rulesText.SetActive(true);
        play.SetActive(false);
        rule.SetActive(false);
    }
    public void HideRules()
    {
        rules.SetActive(false);
        rulesText.SetActive(false);
        play.SetActive(true);
        rule.SetActive(true);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
