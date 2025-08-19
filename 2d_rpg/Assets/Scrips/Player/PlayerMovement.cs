using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//玩家移动计算和速度

public class PlayerMovement : MonoBehaviour
{
    [Header("配置")]
    [SerializeField]
    private float speed;
    //速度
    private PlayerAnimations playerAnimations;//引用PlayerAnimations脚本
    private PlayerActions actions;
    private Player player;
    private Rigidbody2D rb2D;
    private Vector2 moveDirection;
    //移动方向

    private void Awake()
    {
        player = GetComponent<Player>();
        actions = new PlayerActions();
        rb2D = GetComponent<Rigidbody2D>();
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        ReadMovement();//实时读取
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()//移动
    {
        if (player.Stats.Health <= 0) return;
        rb2D.MovePosition(rb2D.position + moveDirection * (speed * Time.fixedDeltaTime));
        //控制玩家目的地，如（1,0）
    }

    private void ReadMovement()//读取移动数据
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        //移动方向=动作集合.移动模块.移动(输入).读取值<2D向量>.归一化处理
        //归一化处理>>控制速度(使其长度为1)

        if (moveDirection == Vector2.zero)
        {
            //animator.SetBool(moving, false);
            playerAnimations.SetMoveBoolTransition(false);
            return;
        }//如果等于0就结束

        playerAnimations.SetMoveBoolTransition(true);
        playerAnimations.SetMoveAnimation(moveDirection);
        //animator.SetBool(moving, true);
        //animator.SetFloat(moveX,moveDirection.x);
        //animator.SetFloat(moveY,moveDirection.y);
    }
    private void OnEnable()
    {
        actions.Enable();
    }
    private void OnDisable()
    {
        actions.Disable();
    }
}
