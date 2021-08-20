using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ESM_Main : MonoBehaviour
{
    public AbilityTargeting targeting;
    public GameObject text;
    public int targetsRequired;
    public int targetsSelected;
    public bool run = false;

    public virtual void GetTargets(AbilityTargeting target, int numberOfTargets)
    {
        targeting = target;
        targetsRequired = numberOfTargets;
        run = true;
    } 

    public virtual void SendTargets()
    {
        if (text != null)
        {
            text.SetActive(false);
        }
        BattleManager.gameState = BattleManager.GameState.cardSelecting;
        EnemySelectorManager.targetsSelected = 0;
        targetsSelected = 0;
        StartCoroutine(targeting.waitForSecond());

        this.enabled = false;



    }
}
