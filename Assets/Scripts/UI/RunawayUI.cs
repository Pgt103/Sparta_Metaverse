using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RunawayUI : BaseUI
{
    RunawayManager runawayManager;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI bestScoreText;
    public Image startText;
    public Image resultText;
    // Start is called before the first frame update
    void Start()
    {
        // 텍스트를 못 가져왔을 때
        if (startText == null)
            Debug.LogError("StartText is null");
        
        if(resultText == null)
            Debug.LogError("ResultText is null");
        
        if(scoreText == null)
            Debug.LogError("ScoreText is null");
        
        startText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
        resultText.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        scoreText.gameObject.SetActive(true); // 점수 표시
        startText.gameObject.SetActive(false); // 시작 전 타이틀 가리기
    }

    public void SetResult() // 결과 ui 출력
    {
        bestScoreText.text = PlayerPrefs.GetFloat("bestScore").ToString("0.00");
        resultText.gameObject.SetActive(true);
    }

    public void UpdateScore(float score) // 텍스트에 점수를 형변환해 넣어준다
    {
        scoreText.text = score.ToString("0.00");
        currentScoreText.text = score.ToString("0.00");
    }

    
}
