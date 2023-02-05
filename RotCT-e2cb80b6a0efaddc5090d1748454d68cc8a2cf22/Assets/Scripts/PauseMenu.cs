using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu: MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool UpgradeMenu = false;
    public GameObject pauseMenuUI;
    public GameObject upgradeMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            upgradeMenuUI.transform.gameObject.SetActive(!upgradeMenuUI.activeInHierarchy);
            Time.timeScale = 0f;
        }
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName: "LoadingScreen");
    }
    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }

    public void UpgradeMenuUI()
    {
        
        upgradeMenuUI.transform.gameObject.SetActive(true); 

    }
    public void LeftButton()
    {
        Debug.Log("Left Button");
        
    }
    public void RightButton()
    {
        Debug.Log("Right Button");
        
    }
}

