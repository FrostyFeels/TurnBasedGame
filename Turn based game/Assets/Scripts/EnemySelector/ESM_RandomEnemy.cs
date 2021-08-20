using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESM_RandomEnemy : ESM_Main
{
    public GameObject[] allTargets;
    public List<GameObject> targets;
    public int chance; 
    public override void GetTargets(AbilityTargeting target, int hitChance)
    {
        base.GetTargets(target, hitChance);
        chance = hitChance;
        SendTargets();
    }

    public override void SendTargets()
    {

        allTargets = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject _enemy in allTargets)
        {
            int i = Random.Range(0, 100);
            if(i <= chance)
            {
                targets.Add(_enemy);
            }
        }

        targeting.targets = targets.ToArray();
        base.SendTargets();

    }
}
