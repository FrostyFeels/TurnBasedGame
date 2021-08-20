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

    private Ability ability;

    [Header("Targets")]
    public int rows;
    public int procChance;
    public TargetMode targetMode;
    public GameObject[] targets;
    
    [Header("attacks")]
    public AbilityAttack attack;



    public void DoAttack(GameObject[] targets)
    {
        attack.DoAttack(targets);
    }

    public void Findtargets(Ability abilities)
    {
        ability = abilities;
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

    public void SaveAbility()
    {
        ability.stats.currentAttackNumber++;
        if (ability.stats.currentAttackNumber < ability.stats.numberOfAttacks)
        {            
            ability.ReturnTargets(ability.stats.currentAttackNumber);
        }
        else
        {
            ability.SaveAbility();
        }

    }

    public IEnumerator waitForSecond()
    {
        yield return new WaitForSeconds(1f);
        this.SaveAbility();
    }
  
}
