using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AbilityTargeting
{
    public enum TargetMode
    {
        Selected, Row, Columm, Diagonal, RandomChance, RandomEnemy, All 
    }

    [Header("Targets")]
    public int rows;
    public int procChance;
    public TargetMode targetMode;
    public GameObject[] targets;
    
    [Header("attacks")]
    public AbilityAttack[] attack;



    public void DoAttack()
    {
        //Do the attacks in the AbilityAttack[]
    }

    public void Findtargets()
    {
        ChooseTargets();
    }

    public void ChooseTargets()
    {
        BattleManager.gameState = BattleManager.GameState.targetSelecting;
        EnemySelectorManager esm = GameObject.Find("ESM").GetComponent<EnemySelectorManager>();
        esm.SetTargetMode(targetMode, this);

        switch (targetMode)
        {
            case TargetMode.Selected:      
                esm.SetTargets(targets.Length);
                break;
            case TargetMode.Row:
            case TargetMode.Columm:
            case TargetMode.Diagonal:
                esm.SetRows(rows);
                break;
            case TargetMode.RandomChance:
            case TargetMode.RandomEnemy:
                esm.SetChance(procChance);
                break;
            case TargetMode.All:
                esm.SetAll();
                break;
        }
    }
  
}
