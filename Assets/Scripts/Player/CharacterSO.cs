using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName ="SO/Character")]
public class CharacterSO : ScriptableObject
{
    [SerializeField] protected GameObject startingWeapon;
    public GameObject StartingWeapon => startingWeapon;
    [SerializeField] protected float maxHealth;
    public float MaxHealth => maxHealth;
    [SerializeField] protected float recovery;
    public float Recovery => recovery;
    [SerializeField] protected float might;
    public float Might => might;
    [SerializeField] protected float moveSpeed;
    public float MoveSpeed => moveSpeed;
    [SerializeField] protected float projectileSpeed;
    public float ProjectileSpeed => projectileSpeed;
}
