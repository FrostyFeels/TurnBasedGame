using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESM_RandomChance : ESM_Main
{
    public GameObject[] allTargets;
    public List<GameObject> targets;
    public List<int> numberOfTarget;
    public int chance;
    public override void GetTargets(AbilityTargeting target, int hitChance)
    {
        base.GetTargets(target, hitChance);
        chance = hitChance;
        SendTargets();
        Debug.Log("LOL");
    }

    public override void SendTargets()
    {
        allTargets = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < chance; i++)
        {
            targets.Add(allTargets[Random.Range(0, allTargets.Length - 1)]);
        }
       
        targeting.targets = targets.ToArray();
        base.SendTargets();
    }

}
