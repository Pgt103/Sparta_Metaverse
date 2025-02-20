using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject player;
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

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
