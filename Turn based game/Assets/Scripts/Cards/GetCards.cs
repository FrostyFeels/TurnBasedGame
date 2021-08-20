using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetCards : MonoBehaviour
{
    public GameObject[] cards;
    public Ability[] abilities;
    
    public void SetCardsActive()
    {
        for (int i = 0; i < abilities.Length; i++)
        {
            if (CheckCardValidation(abilities[i])) {
                cards[i].SetActive(true);
                TextMeshPro text = cards[i].GetComponentInChildren<TextMeshPro>();
                text.text = abilities[i].stats.description;

                SelectCard selectCard = cards[i].GetComponent<SelectCard>();
                selectCard.ability = abilities[i];
            }
        }
    }

    public bool CheckCardValidation(Ability ability)
    {
        if(ability.stats.cooldownEnd <= BattleManager.turn)
        {
            return true;
        }

        return false;
    }
}
