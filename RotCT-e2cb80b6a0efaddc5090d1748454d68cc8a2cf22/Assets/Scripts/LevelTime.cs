using System;
using TMPro;
using UnityEngine;

public class LevelTime : MonoBehaviour
{
    public static LevelTime Instance;
    public float timer = 300f;
    public TextMeshProUGUI timeText;
    public float minutes;
    public int killedEnemy;
    public GameObject upgradeUI, baseInGameUI;
    public bool isTimeStop = true;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    void Update()
    {
        if (timer > 0 && isTimeStop) timer -= Time.deltaTime;
        else timer = 0;
        DisplayTime(timer);
        if (killedEnemy == 5)
        {
            upgradeUI.SetActive(true);
            baseInGameUI.SetActive(false);
            StopGame();
        }
    }

    public void StopGame()
    {
        isTimeStop = false;
    }

    public void StartGame()
    {
        isTimeStop = true;
    }

    private void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0) timeToDisplay = 0; 
        minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
