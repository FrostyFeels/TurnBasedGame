using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public SOCharacterStats firstStat;
    public SOCharacterStats secondStat;

    public CharacterHealth health;

    public SOCharacterStats currentStat;
   
    public void Awake()
    {
        currentStat = firstStat;
    }

    public void SwapStats()
    {
        if(currentStat == firstStat)
        {
            currentStat = secondStat;
        }
        else if(currentStat == secondStat)
        {
            currentStat = firstStat;
        }

        health.armor = currentStat.armor;
    }

}
