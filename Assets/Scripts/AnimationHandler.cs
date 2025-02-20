using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsMove = Animator.StringToHash("IsMove"); // 이동 확인
    private static readonly int IsJump = Animator.StringToHash("IsJump"); // 점프 확인
    
    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>(); // 애니메이터 컴포넌트 호출
    }

    public void Move(Vector2 obj) // 이동
    {
        animator.SetBool(IsMove, obj.magnitude > .5f);
    }

    public void Jump() // 점프
    {
        if(animator.GetBool(IsJump) == false)
            animator.SetBool(IsJump, true);
    }

    public void JumpEnd() // 착지
    {
        animator.SetBool(IsJump, false);
    }
}
