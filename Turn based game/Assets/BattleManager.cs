using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleManager : MonoBehaviour
{   
    public static int numberOfTargets;
    public static int targetsSelected;

    [SerializeField]
    public static AbilityTargeting target;

    
    public enum GameState
    {
        cardSelecting,
        targetSelecting,
        finishedTargetSelecting
        
    }

    public static GameState gameState;

    public static void WaitForTargetsToBeSelected(AbilityTargeting targeting)
    {
        target = targeting;
    }

    public void Update()
    {
        if (numberOfTargets <= targetsSelected && gameState == GameState.targetSelecting)
        {
            gameState = GameState.finishedTargetSelecting;
        }

        if(gameState == GameState.finishedTargetSelecting)
        {
            target.targetscript.Selected();
            gameState = GameState.cardSelecting;
        }
    }



}
