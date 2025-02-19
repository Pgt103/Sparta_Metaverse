using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMeshEffect : MonoBehaviour
{
    public float moveMax;
    public float speed;
    public TextMesh textMesh;
    private bool IsTextMoving = false;

    private Vector3 pos;

    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        pos = transform.position;
    }

    void Update()
    {
        Vector3 dirPos = pos;
        dirPos.y = pos.y + moveMax * Mathf.Sin(Time.time * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
        }
    }
}
