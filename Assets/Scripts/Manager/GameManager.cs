using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    protected PlayerController playercontroller;
    
    private static GameManager gameManager;

    public static GameManager Instance { get { return gameManager; } }
    
    protected RunawayUI runawayUI;
    
    public RunawayUI RunawayUI { get { return runawayUI; } }

    public virtual void Awake()
    {
        Debug.Log("Awake 실행");
        if (gameManager == null)
            gameManager = this;
        
        playercontroller = FindObjectOfType<PlayerController>();
    }
}
