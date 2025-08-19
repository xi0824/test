using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ω°øµ÷µº∞À¿Õˆ

public class PlayerHealth : MonoBehaviour, IDamamgeable
{
    [Header("≈‰÷√")]
    [SerializeField] private PlayerStats stats;

    private PlayerAnimations playerAnimations;

    private void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P ))
        {
            TakeDamage(1f);
        }
    }
    public void TakeDamage(float amount)
    {
        stats.Health -= amount;
        if(stats.Health <= 0f)
        {
            PlayerDead();
        }
    }
    private void PlayerDead()
    {
        playerAnimations.SetDeadAnimation();
        Debug.Log("Dead");
    }
}
