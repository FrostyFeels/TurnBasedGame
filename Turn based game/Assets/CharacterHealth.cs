using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public CharacterStats stats;

    public float health, armor;

    public void Start()
    {
        health = stats.stats.hp;
        armor = stats.stats.armor;
    }


    public void BecomeDowned()
    {
        gameObject.tag = "Downed";
    }

    public void Die()
    {

    }

}
