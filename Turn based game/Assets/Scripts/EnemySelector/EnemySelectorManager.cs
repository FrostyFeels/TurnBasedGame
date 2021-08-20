using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelectorManager : MonoBehaviour
{
    public static int targetsRequired;
    public static int targetsSelected;

    public static List<GameObject> attackLocation;

    public int rows;
    public int chanceToHit;
   

    public ESM_Select select;
    public ESM_Row row;
    public ESM_RandomEnemy randomEnemy;
    public ESM_RandomChance randomChance;
    public ESM_Diagonal diagonal;
    public ESM_Colum colum;
    public ESM_ALL all;

    public AbilityTargeting.TargetMode targetMode;
    public AbilityTargeting targeting;

    public GameObject chooseTargets;
    public GameObject chooseLanes;

    public void SetTargetMode(AbilityTargeting.TargetMode targetmode, AbilityTargeting target)
    {
        targetMode = targetmode;
        targeting = target;
    }

    public void SetTargets(int targetsNeeded)
    {

        chooseTargets.SetActive(true);
        switch (targetMode)
        {
            case AbilityTargeting.TargetMode.Selected:
                select.enabled = true;
                select.GetTargets(targeting, targetsNeeded);
                select.text = chooseTargets;
                break;
        }
    }

    public void SetRows(int rows)
    {
        chooseLanes.SetActive(true);
            switch (targetMode)
            {
                case AbilityTargeting.TargetMode.Row:
                row.enabled = true;
                row.text = chooseLanes;
                row.GetTargets(targeting, rows);
                
                    break;
                case AbilityTargeting.TargetMode.Columm:
                colum.enabled = true;
                colum.GetTargets(targeting, rows);
                colum.text = chooseLanes;
                break;
                case AbilityTargeting.TargetMode.Diagonal:
                diagonal.enabled = true;
                diagonal.GetTargets(targeting, rows);
                diagonal.text = chooseLanes;
                break;
            }
    }

    public void SetChance(int chance)
    {
        switch (targetMode)
        {
            case AbilityTargeting.TargetMode.RandomChance:
                randomChance.GetTargets(targeting,chance);
                break;
            case AbilityTargeting.TargetMode.RandomEnemy:
                randomEnemy.GetTargets(targeting, chance);
                break;
        }
    }

    public void SetAll()
    {
        switch (targetMode)
        {
            case AbilityTargeting.TargetMode.All:
                all.GetTargets(targeting, 5);
                break;
        }
    }
}
