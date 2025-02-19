using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunawayManager : GameManager
{
    public bool IsGameStarted = false;
    void Awake()
    {
        runawayUI = FindObjectOfType<RunawayUI>();

        if (playercontroller == null)
        {
            Debug.LogError("No playercontroller found");
            playercontroller = FindObjectOfType<PlayerController>();
        }
        
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.anyKeyDown && !IsGameStarted)
        {
            IsGameStarted = true;
            runawayUI.StartGame();
        }

        if (IsGameStarted)
        {
            runawayUI.UpdateScore(Time.timeSinceLevelLoad);
        }

        if (playercontroller == null)
        {
            Debug.Log("No player controller assigned");
            return;
        }
        
        if (playercontroller.IsDead)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
            Time.timeScale = 0;
            runawayUI.SetResult();
    }
}
