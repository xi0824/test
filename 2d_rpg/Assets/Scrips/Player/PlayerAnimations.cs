using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//玩家移动和动画

public class PlayerAnimations : MonoBehaviour
{
    private readonly int moveX = Animator.StringToHash("MoveX");
    private readonly int moveY = Animator.StringToHash("MoveY");
    private readonly int moving = Animator.StringToHash("Moving");
    private readonly int dead = Animator.StringToHash("Dead");

    private Animator animator;//动画

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void SetDeadAnimation()//设置玩家死亡动画
    {
        animator.SetTrigger(dead);
    }

    public void SetMoveBoolTransition(bool value)//玩家状态（是否移动）
    {
        animator.SetBool(moving, value);
    }
    public void SetMoveAnimation(Vector2 dir)//玩家移动
    {
        animator.SetFloat(moveX, dir.x);
        animator.SetFloat(moveY, dir.y);
    }
}
