using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="PlayerStats",menuName = "Player Stats")]
//ָ��Assets��SO����Ҳ˵�
public class PlayerStats : ScriptableObject
{
    [Header("����")]
    public int Level;

    [Header("����")]
    public float Health;
    public float MaxHealth;

}
