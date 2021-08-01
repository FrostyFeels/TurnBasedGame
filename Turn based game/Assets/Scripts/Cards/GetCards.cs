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
            cards[i].SetActive(true);
            TextMeshPro text = cards[i].GetComponentInChildren<TextMeshPro>();
            text.text = abilities[i].description;

            SelectCard selectCard = cards[i].GetComponent<SelectCard>();
            selectCard.ability = abilities[i];
        }
    }
}
