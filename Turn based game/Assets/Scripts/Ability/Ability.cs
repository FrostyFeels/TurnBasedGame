using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    private BattleManager battle;

    public string abilityName;
    public string description;
    public AbilityTargeting[] attack;


    public void Start()
    {
        battle = GameObject.Find("BattleManager").GetComponent<BattleManager>();
    }

    public void startAttack()
    {
        foreach (AbilityTargeting _attack in attack)
        {
            _attack.DoAttack();
        }
    }

    public void ReturnTargets()
    {
        foreach (AbilityTargeting _attack in attack)
        {
            _attack.ChooseTargets();
            battle.abilities.Add(this);
        }
    }

}
