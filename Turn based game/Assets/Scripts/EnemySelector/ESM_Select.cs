using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESM_Select : ESM_Main
{
    public override void GetTargets(AbilityTargeting target, int numberOfTargets)
    {
        base.GetTargets(target, numberOfTargets);
    }

    public override void SendTargets()
    {
       

        GameObject[] taggedenemies = GameObject.FindGameObjectsWithTag("TaggedEnemy");
        foreach (GameObject _taggedEnemy in taggedenemies)
        {
            _taggedEnemy.tag = "Enemy";
        }

        targeting.targets = taggedenemies;

        base.SendTargets();
       

        
    }

    public void Update()
    {      
        targetsSelected = EnemySelectorManager.targetsSelected;     
        if (targetsSelected >= targetsRequired && run)
        {
            SendTargets();
            run = false;
        }
    }



}
