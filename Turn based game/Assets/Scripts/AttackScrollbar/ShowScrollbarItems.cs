using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScrollbarItems : MonoBehaviour
{
    private BattleManager battle;
    public GameObject attack;
    public ChangeScrollbarText scrollText;

    public int numberOfAttacks;
    public int oldNumberOfAttack;

    public void Start()
    {
        battle = GameObject.Find("BattleManager").GetComponent<BattleManager>();
        numberOfAttacks = battle.abilities.Count;
    }

    public void Update()
    {
        oldNumberOfAttack = numberOfAttacks;

        numberOfAttacks = battle.abilities.Count;

        if (numberOfAttacks != oldNumberOfAttack && numberOfAttacks > oldNumberOfAttack)
        {
            GameObject attackPrefab = Instantiate(attack, transform);
            ChangeScrollbarText change = attackPrefab.GetComponent<ChangeScrollbarText>();


            change.ChangeStats(battle.abilities[numberOfAttacks - 1]);
            change.show = this;
        }
    }
}
