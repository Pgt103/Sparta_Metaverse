using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager uiManager;
    public static UIManager Instance { get { return uiManager; } }

    private void Awake()
    {
        if(uiManager == null)
            uiManager = this;
    }
}
