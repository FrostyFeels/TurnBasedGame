using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleManager : MonoBehaviour
{   
    public List<Ability> abilities;

    public enum GameState
    {
        cardSelecting,
        targetSelecting,
        finishedTargetSelecting
        
    }

    public static GameState gameState;

}
