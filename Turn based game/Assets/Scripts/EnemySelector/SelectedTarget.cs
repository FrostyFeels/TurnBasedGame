using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedTarget : MonoBehaviour
{
    public void OnMouseDown()
    {
        if(BattleManager.gameState == BattleManager.GameState.targetSelecting)
        {
            if (gameObject.CompareTag("Enemy")) 
            {
                gameObject.tag = "TaggedEnemy";
                EnemySelectorManager.targetsSelected++;
            }

            if(gameObject.CompareTag("AttackPoint"))
            {
                Debug.Log("LOL NO");
                gameObject.tag = "ChosenTarget";
                EnemySelectorManager.targetsSelected++;
            }              
        }
    }
}
