using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ƶ�������ٶ�

public class PlayerMovement : MonoBehaviour
{
    [Header("����")]
    [SerializeField]
    private float speed;
    //�ٶ�
    private PlayerAnimations playerAnimations;//����PlayerAnimations�ű�
    private PlayerActions actions;
    private Player player;
    private Rigidbody2D rb2D;
    private Vector2 moveDirection;
    //�ƶ�����

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
        ReadMovement();//ʵʱ��ȡ
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()//�ƶ�
    {
        if (player.Stats.Health <= 0) return;
        rb2D.MovePosition(rb2D.position + moveDirection * (speed * Time.fixedDeltaTime));
        //�������Ŀ�ĵأ��磨1,0��
    }

    private void ReadMovement()//��ȡ�ƶ�����
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        //�ƶ�����=��������.�ƶ�ģ��.�ƶ�(����).��ȡֵ<2D����>.��һ������
        //��һ������>>�����ٶ�(ʹ�䳤��Ϊ1)

        if (moveDirection == Vector2.zero)
        {
            //animator.SetBool(moving, false);
            playerAnimations.SetMoveBoolTransition(false);
            return;
        }//�������0�ͽ���

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
