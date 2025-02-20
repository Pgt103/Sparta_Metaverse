using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    RunawayUI runawayUI;
    private float score;
    private void Update()
    {
        if (runawayUI == null)
        {
            score = PlayerPrefs.GetFloat("bestScore");
            text.text = score.ToString("0.00");
        }
        
    }
}
