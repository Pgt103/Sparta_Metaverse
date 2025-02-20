using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCScore : MonoBehaviour
{
    public TextMeshProUGUI text; // 최고점수를 받아올 변수
    
    RunawayUI runawayUI;
    private float score;
    private void Update()
    {
        if (runawayUI == null)
        {
            score = PlayerPrefs.GetFloat("bestScore"); // bestScore 키 값에 저장된 변수를 가져온다.
            text.text = score.ToString("0.00"); // 출력
        }
        
    }
}
