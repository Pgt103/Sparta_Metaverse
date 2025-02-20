using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameButton : MonoBehaviour
{
    PlayerController playerController;
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 불러오기
    }

    public void BackToBase()
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
