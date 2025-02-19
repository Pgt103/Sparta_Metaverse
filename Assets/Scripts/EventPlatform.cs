using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환을 위해 필요

public class EventPlatform : MonoBehaviour
{
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
        if (collision.gameObject.CompareTag("Player")) // 플레이어가 떠나면
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

    void Update()
    {
        if (isPlayerOnPlatform && Input.GetKeyDown(KeyCode.E) && gameObject.CompareTag("Portal")) // E키를 누르면
        {
            FadeInOut.Play(GlobalValue.Transition.Fade);
            Invoke("Portal", 2f);
        }
    }
}
