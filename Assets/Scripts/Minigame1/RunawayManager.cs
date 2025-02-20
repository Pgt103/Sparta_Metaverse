using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RunawayManager : GameManager
{
    public bool IsGameStarted = false; // 게임이 시작되었는지 확인
    private float time; // 게임 플레이 점수(시간) 저장
    void Awake()
    {
        runawayUI = FindObjectOfType<RunawayUI>();

        if (playercontroller == null) // 상속된 게임매니저에서 가져오지 못했을 경우
        {
            Debug.LogError("No playercontroller found"); // 오류 메세지 출력
            playercontroller = FindObjectOfType<PlayerController>(); // 호출
        }
        
        Time.timeScale = 0; // 씬에 진입했을 때 바로 시작되지 않게 시간을 멈춘다
    }

    void Update()
    {
        if (Input.anyKeyDown && !IsGameStarted) // 게임 시작
        {
            IsGameStarted = true;
            runawayUI.StartGame();
        }

        if (IsGameStarted)
        {
            time = Time.timeSinceLevelLoad; // 현재 흐른 시간 저장
            runawayUI.UpdateScore(Time.timeSinceLevelLoad);
        }

        if (playercontroller == null) // 플레이어 캐릭터가 존재하지 않을 때
        {
            Debug.Log("No player controller assigned");
            return;
        }
        
        if (playercontroller.IsDead) // 플레이어 사망시 게임종료
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        

        if (PlayerPrefs.HasKey("bestScore")) // 최고점수 저장
        {
            float best = PlayerPrefs.GetFloat("bestScore");

            if (best < time) // time이 전에 저장된 best보다 높을 때 bestScore의 키값을 time으로 변경
            {
                PlayerPrefs.SetFloat("bestScore", time);
                runawayUI.bestScoreText.text = time.ToString("N2");
            }
            else
            {
                runawayUI.bestScoreText.text = best.ToString("N2");
            }
        }
        else // 게임 처음 시작 시 키값이 없을 경우
        {
            PlayerPrefs.SetFloat("bestScore", time);
            runawayUI.bestScoreText.text = time.ToString("N2");
        }
            
        runawayUI.SetResult(); // 결과 출력
    }
}
