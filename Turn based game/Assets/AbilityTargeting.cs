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

    public TargetScript targetscript;
    public TargetMode targetMode;
    public GameObject[] targets;

    public AbilityAttack[] attack;



    public void DoAttack()
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
                break;
            case TargetMode.middleRow:
                break;
            case TargetMode.backRow:
                break;
            case TargetMode.straight:
                break;
            case TargetMode.diagonal:
                break;
            case TargetMode.all:
                targets = targetscript.all();

                break;
            default:
                break;
        }
    }
  
}
