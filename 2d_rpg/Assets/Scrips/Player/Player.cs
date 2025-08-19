using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("配置")]
    [SerializeField] private PlayerStats stats;
    public PlayerStats Stats => stats;
    //一个用来传递数据的公共值
}