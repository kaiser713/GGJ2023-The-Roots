using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Animator ani;

    public GameObject msgBox;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        Debug.Log("Start");
        StartCoroutine(FadeIn());
    }

    public void GameOptionOpen()
    {
        msgBox.SetActive(true);
    }

    public void GameOptionClose()
    {
        msgBox.SetActive(false);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    IEnumerator FadeIn()
    {
        ani.SetTrigger("Fade");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
