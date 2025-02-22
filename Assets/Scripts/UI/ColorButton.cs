using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour // 플레이어 스프라이트 색 변경 버튼을 모아둔 클래스
{
    public GameObject player;
    
    // 플레이어 스프라이트 색 변경 메서드
    public void ChangeColorRed()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // 태그를 통해 플레이어 오브젝트를 인식
        
        if (player != null)
        {
            SpriteRenderer spriteRenderer = player.GetComponentInChildren<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.color = new Color(1, 0, 0);
            }
        }
    }

    public void ChangeColorGreen()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        if (player != null)
        {
            SpriteRenderer spriteRenderer = player.GetComponentInChildren<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.color = new Color(0, 1, 0);
            }
        }
    }

    public void ChangeColorYellow()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        if (player != null)
        {
            SpriteRenderer spriteRenderer = player.GetComponentInChildren<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.color = new Color(1, 1, 0);
            }
        }
    }

    public void ChangeColorOrigin()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        if (player != null)
        {
            SpriteRenderer spriteRenderer = player.GetComponentInChildren<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.color = new Color(1, 1, 1);
            }
        }
    }
}
