using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AbilityTargeting
{
    public enum TargetMode
    {
        selected, frontRow, middleRow, backRow, straight, diagonal, all
    }

    [Header("Targets")]
    public TargetScript targetscript;
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
        switch (targetMode)
        {
            case TargetMode.selected:
                BattleManager.numberOfTargets = targets.Length;
                BattleManager.gameState = BattleManager.GameState.targetSelecting;
                BattleManager.WaitForTargetsToBeSelected(this);
                break;
            case TargetMode.frontRow:
                targets = targetscript.FrontRow();
                break;
            case TargetMode.middleRow:
                targets = targetscript.MiddleRow();
                break;
            case TargetMode.backRow:
                targets = targetscript.BackRow();
                break;
            case TargetMode.straight:
                targets = targetscript.FrontRow();
                break;
            case TargetMode.diagonal:
                targets = targetscript.FrontRow();
                break;
            case TargetMode.all:
                targets = targetscript.all();

                break;
            default:
                break;
        }
    }
  
}
