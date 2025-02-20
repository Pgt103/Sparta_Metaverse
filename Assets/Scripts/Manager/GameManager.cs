using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    protected PlayerController playercontroller; // 플레이어
    
    private static GameManager gameManager; // 싱글톤 선언
    public static GameManager Instance { get { return gameManager; } }
    
    protected RunawayUI runawayUI;
    
    public RunawayUI RunawayUI { get { return runawayUI; } }

    public virtual void Awake()
    {
        Time.timeScale = 1; 
        Debug.Log("Awake 실행");
        if (gameManager == null)
            gameManager = this;
        
        playercontroller = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        // 타이틀 씬에서 F를 눌러 게임 진입
        if (SceneManager.GetActiveScene().buildIndex == 0 && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
