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
        scoreText.gameObject.SetActive(true);
        startText.gameObject.SetActive(false);
    }

    public void SetResult()
    {
        Time.timeScale = 0;
        bestScoreText.text = PlayerPrefs.GetFloat("bestScore").ToString("0.00");
        resultText.gameObject.SetActive(true);
    }

    public void UpdateScore(float score)
    {
        scoreText.text = score.ToString("0.00");
        currentScoreText.text = score.ToString("0.00");
    }

    
}
