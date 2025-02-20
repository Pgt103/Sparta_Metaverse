using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image titleScreen;

    private void Awake()
    {
        if (titleScreen == null)
        {
            Debug.LogError("Title screen reference is null");
        }
    }

    public void Title()
    {
        titleScreen.gameObject.SetActive(true);
    }
}
