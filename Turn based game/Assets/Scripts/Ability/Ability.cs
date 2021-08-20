using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ability : MonoBehaviour
{


    public Stats stats;



    public void Start()
    {
        stats.battle = GameObject.Find("BattleManager").GetComponent<BattleManager>();
        stats.numberOfAttacks = stats.attack.Length;
        stats.cooldownEnd = BattleManager.turn + stats.startingCd;
    }

   
    public void ReturnTargets(int i)
    {
        stats.attack[i].Findtargets(this);
    }
    public void SaveAbility()
    {
        stats.allTargets = new GameObject[stats.attack.Length][];

        for (int i = 0; i < stats.attack.Length; i++)
        {        
            stats.allTargets[i] = new GameObject[stats.attack[i].targets.Length];
            for (int j = 0; j < stats.attack[i].targets.Length; j++)
            {
                stats.allTargets[i][j] = stats.attack[i].targets[j];             
            }
        }
        stats.battle.abilities.Add(CloneAbility(stats));
    }

    public Stats CloneAbility(Stats ability)
    {
        Stats newAbility = new Stats();
        newAbility.battle = ability.battle;
        newAbility.abilityName = ability.abilityName;
        newAbility.description = ability.description;
        newAbility.attack = ability.attack;
        newAbility.allTargets = ability.allTargets;
        return newAbility;
    }


    [System.Serializable]
    public class Stats
    {
        public BattleManager battle;

        [Header("info")]
        public string abilityName;
        public string description;
        public int cost;

        [Header("cooldown")]
        public int cooldown;
        public int startingCd;
        public int cooldownEnd;

        [Header("attack")]
        public int numberOfAttacks;
        public int currentAttackNumber;
        public bool repeatableAttack;
        
        public AbilityTargeting[] attack;
        //public GameObject[] targets;

        public GameObject[][] allTargets;
    }

}
