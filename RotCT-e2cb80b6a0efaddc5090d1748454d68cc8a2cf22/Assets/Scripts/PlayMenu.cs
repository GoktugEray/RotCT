using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    public static bool GameOpened = true;
    public GameObject playMenuUI;
    public GameObject creditUI;
    public GameObject storyUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (GameOpened)
            {
                
            }
            else
            {
                
            }
        }
    }

    public void Play()
    {
        playMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameOpened = false;
        Debug.Log("Starting Game...");
        SceneManager.LoadScene(sceneName: "Menu");
    }
    public void Story()
    {
        playMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameOpened = true;
        playMenuUI.transform.gameObject.SetActive(false);
        creditUI.transform.gameObject.SetActive(false);
        storyUI.transform.gameObject.SetActive(true);
        Debug.Log("Story are shown...");
        
    }
    public void Credits()
    {
        playMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameOpened = true;
        playMenuUI.transform.gameObject.SetActive(false);
        creditUI.transform.gameObject.SetActive(true);
        storyUI.transform.gameObject.SetActive(false);
        Debug.Log("Credits are shown...");

    }
    public void Back()
    {
        playMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameOpened = true;
        playMenuUI.transform.gameObject.SetActive(true);
        creditUI.transform.gameObject.SetActive(false);
        storyUI.transform.gameObject.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}

