using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESM_ALL : ESM_Main
{
    public override void GetTargets(AbilityTargeting target, int numberOfTargets)
    {
        base.GetTargets(target, numberOfTargets);
        SendTargets();
        
    }

    public override void SendTargets()
    {
        base.SendTargets();
        targeting.targets = GameObject.FindGameObjectsWithTag("Enemy");
    }

}
