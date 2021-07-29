using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScrollbarItems : MonoBehaviour
{
    private BattleManager battle;
    public GameObject attack;

    public int numberOfAttack;
    public int oldNumberOfAttack;

    public void Start()
    {
        battle = GameObject.Find("BattleManager").GetComponent<BattleManager>();
        numberOfAttack = battle.abilities.Count;
    }

    public void Update()
    {
        oldNumberOfAttack = numberOfAttack;

        numberOfAttack = battle.abilities.Count;

        if(numberOfAttack != oldNumberOfAttack)
        {
            GameObject attackPrefab = Instantiate(attack, transform);
            ChangeScrollbarText change = attackPrefab.GetComponent<ChangeScrollbarText>();
            change.ability = battle.abilities[numberOfAttack-1];
        }
    }



}
