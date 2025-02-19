using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsMove = Animator.StringToHash("IsMove");
    private static readonly int IsJump = Animator.StringToHash("IsJump");
    
    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        animator.SetBool(IsMove, obj.magnitude > .5f);
    }

    public void Jump()
    {
        if(animator.GetBool(IsJump) == false)
            animator.SetBool(IsJump, true);
    }

    public void InvincibilityEnd()
    {
        animator.SetBool(IsJump, false);
    }

    public void JumpEnd()
    {
        animator.SetBool(IsJump, false);
    }
}
