using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    // 인스펙터에서 수정할 용도
    [SerializeField] private Image fadeImage;
    [SerializeField] private float fadeTime = 1f;
 
    // 실제 코드에서 사용할 용도
    static private Image FadeImage;
    static private float FadeTime;
    
    static Sequence sequenceFadeInout;
    void Awake()
    {
        FadeImage = fadeImage;
        FadeTime = fadeTime;
        
        FadeImage.enabled = false; // 비활성화
    }

    private void Start()
    {
        sequenceFadeInout = DOTween.Sequence()
            .SetAutoKill(false) // DoTween Sequence는 기본적으로 일회용임. 재사용하려면 써주자.
            .OnRewind(() => // 실행 전. OnStart는 unity Start 함수가 불릴 때 호출됨. 낚이지 말자.
            {
                FadeImage.enabled = true;
            })
            .Append(FadeImage.DOFade(1.0f, FadeTime)) // 어두워짐. 알파 값 조정.
            .Append(FadeImage.DOFade(0.0f, FadeTime)) // 밝아짐. 알파 값 조정.
            .OnComplete(() => // 실행 후.
            {
                FadeImage.enabled = false;
            });
    }

    static public void Play(GlobalValue.Transition transition)
    {
        switch (transition)
        {
            case GlobalValue.Transition.Fade: Fade(); break;
        }
    }

    static private void Fade()
    {
        sequenceFadeInout.Play();
    }
}
