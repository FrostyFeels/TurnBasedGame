using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class ChangeScrollbarText : MonoBehaviour
{
    public BattleManager battle;
    public Ability ability;
    public TextMeshProUGUI name;
    public TextMeshProUGUI describtion;
    Color color;

    private void Start()
    {
        battle = GameObject.Find("BattleManager").GetComponent<BattleManager>();

        Debug.Log("WHY RUN NOW");
        name.text = ability.name;
        describtion.text = ability.description;
        color.r = 255;
        color.b = 255;
        color.g = 255;
    }

    public void showTargets()
    {
        for (int i = 0; i < ability.attack[0].targets.Length; i++)
        {
            GameObject target = ability.attack[0].targets[i];

            Selected selected = target.GetComponent<Selected>();

            selected.showOutline();             
        }
    }


    public void DeleteAttack()
    {
        battle.abilities.Remove(ability);
        Destroy(gameObject);
    }
}
