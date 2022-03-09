using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy")]
public class Enemy : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

    public int amount;
    public int strength;
    public AttackType attackType;
    public List<AbilityType> abillityTypeList;
}
