using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ƶ��Ͷ���

public class PlayerAnimations : MonoBehaviour
{
    private readonly int moveX = Animator.StringToHash("MoveX");
    private readonly int moveY = Animator.StringToHash("MoveY");
    private readonly int moving = Animator.StringToHash("Moving");
    private readonly int dead = Animator.StringToHash("Dead");

    private Animator animator;//����

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void SetDeadAnimation()//���������������
    {
        animator.SetTrigger(dead);
    }

    public void SetMoveBoolTransition(bool value)//���״̬���Ƿ��ƶ���
    {
        animator.SetBool(moving, value);
    }
    public void SetMoveAnimation(Vector2 dir)//����ƶ�
    {
        animator.SetFloat(moveX, dir.x);
        animator.SetFloat(moveY, dir.y);
    }
}
