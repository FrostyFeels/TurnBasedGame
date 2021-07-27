using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedTarget : MonoBehaviour
{
    public void OnMouseDown()
    {
        if(BattleManager.gameState == BattleManager.GameState.targetSelecting)
        {
            gameObject.tag = "TaggedEnemy";
            BattleManager.targetsSelected++;
            Debug.Log("Something was done");
        }
    }
}
