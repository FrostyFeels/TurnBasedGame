using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "character")]
public class SOCharacterStats : ScriptableObject
{
    public Sprite sprite;

    public float hp;
    public float damage;
    public float armor;
    public float baseVision;
    public float turns;
}
