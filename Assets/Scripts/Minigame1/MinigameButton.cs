using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameButton : MonoBehaviour // 미니게임 RUNAWAY에서 사용되는 버튼을 정리한 클래스
{
    PlayerController playerController;
    
    public void Restart() // 미니게임 재사작
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 불러오기
    }

    public void BackToBase() // 미니게임을 종료하고 메인씬으로 돌아가는 버튼
    {
        if(playerController != null)
        {
            playerController.IsDead = false; 
        }
        else
        {
            Debug.Log("Player not found");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // 메인씬 불러오기
        Time.timeScale = 1;
    }
}
