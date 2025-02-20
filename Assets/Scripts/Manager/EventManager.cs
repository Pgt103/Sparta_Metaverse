using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환을 위해 필요

public class EventPlatform : MonoBehaviour
{
    GameManager gameManager;
    
    public GameObject speechBubble; // 말풍선 UI

    private bool isPlayerOnPlatform = false;

    void Start()
    {
        if (speechBubble != null)
        {
            speechBubble.SetActive(false); // 초기에는 말풍선 비활성화
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 플레이어가 닿으면
        {
            isPlayerOnPlatform = true;
            if (speechBubble != null)
            {
                Debug.Log("말풍선 활성화");
                speechBubble.SetActive(true); // 말풍선 UI 활성화
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 플레이어가 오브젝트를 벗어나면
        {
            isPlayerOnPlatform = false;
            if (speechBubble != null)
            {
                Debug.Log("말풍선 비활성화");
                speechBubble.SetActive(false); // 말풍선 UI 비활성화
            }
        }
    }

    void Portal()
    {
        Debug.Log("미니게임으로 이동");
        // 미니게임으로 변경
        SceneManager.LoadScene("Minigame1");
    }
    
    public void GameExit() // 게임 종료
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

    void Update()
    {
        // 오브젝트 접촉 and e키를 눌렀을 때 상호작용이 있는 오브젝트는 반응한다
        if (isPlayerOnPlatform && Input.GetKeyDown(KeyCode.E)) 
        {
            if (gameObject.CompareTag("Portal")) 
            {
                Portal();
            }
            else if (gameObject.CompareTag("Quit"))
            {
                GameExit();
            }
        }
        
    }
}
