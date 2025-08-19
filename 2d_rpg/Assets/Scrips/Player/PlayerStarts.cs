using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="PlayerStats",menuName = "Player Stats")]
//指向Assets的SO的玩家菜单
public class PlayerStats : ScriptableObject
{
    [Header("配置")]
    public int Level;

    [Header("健康")]
    public float Health;
    public float MaxHealth;

}
