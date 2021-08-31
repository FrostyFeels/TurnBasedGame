using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleManager : MonoBehaviour
{
    public GameObject[] allies;
    public GameObject[] enemies;
    
    public List<GameObject> targets;
    public List<Ability.Stats> abilities;
    public static bool finishSwapping;

    public static int turn;

    public enum GameState
    {
        idle,
        cardSelecting,
        swappingCharacters,
        targetSelecting    
    }

    public static GameState gameState;

    public void Start()
    {
        gameState = GameState.idle;
    }


    public void StartAttacks()
    {
        foreach (Ability.Stats _attack in abilities)
        {
            
            for (int i = 0; i < _attack.attack.Length; i++)
            {
                GetTargets(_attack.allTargets, i);
                _attack.attack[i].DoAttack(targets.ToArray());
                targets.Clear();
            }
        }



    }

    public void GetTargets(GameObject[][] target, int row)
    {
        Debug.Log(target.Length);

        for (int i = 0; i < target[row].Length; i++)
        {
            targets.Add(target[row][i]);
        }
    }

}
