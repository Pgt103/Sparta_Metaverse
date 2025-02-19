using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RunawayManager : GameManager
{
    public bool IsGameStarted = false;
    private float time;
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
            time = Time.timeSinceLevelLoad;
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
        

        if (PlayerPrefs.HasKey("bestScore"))
        {
            float best = PlayerPrefs.GetFloat("bestScore");

            if (best < time)
            {
                PlayerPrefs.SetFloat("bestScore", time);
                runawayUI.bestScoreText.text = time.ToString("N2");
            }
            else
            {
                runawayUI.bestScoreText.text = best.ToString("N2");
            }
        }
        else
        {
            PlayerPrefs.SetFloat("bestScore", time);
            runawayUI.bestScoreText.text = time.ToString("N2");
        }
            
        runawayUI.SetResult();
    }
}
