using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{

    public string abilityName;
    public string description;
    public AbilityTargeting[] attack;



    public void startAttack()
    {
        foreach (AbilityTargeting _attack in attack)
        {
            _attack.DoAttack();
        }
    }

}
