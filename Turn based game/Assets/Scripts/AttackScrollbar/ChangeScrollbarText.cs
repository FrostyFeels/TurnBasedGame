using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class ChangeScrollbarText : MonoBehaviour
{
    public BattleManager battle;
    public Ability.Stats ability;
    public TextMeshProUGUI abilityName;
    public TextMeshProUGUI describtion;
    public ShowScrollbarItems show;
    public TextMeshProUGUI showTargetText;
    Color color;

    private void Start()
    {
        battle = GameObject.Find("BattleManager").GetComponent<BattleManager>();

        color.r = 255;
        color.b = 255;
        color.g = 255;
    }

    public void ChangeStats(Ability.Stats stats)
    {
        ability = stats;
        abilityName.text = ability.abilityName;
        describtion.text = ability.description;
    }

    public void showTargets()
    {
        if (show.scrollText == this)
        {
            HideTargets();
            return;
        }
            

        if(show.scrollText != null && show.scrollText != this)
        {
            show.scrollText.HideTargets();
        }
        
        show.scrollText = this;

        for (int i = 0; i < ability.attack.Length; i++)
        {
            for (int j = 0; j < ability.attack[i].targets.Length; j++)
            {            
                GameObject target = ability.allTargets[i][j];           
                Selected selected = target.GetComponent<Selected>();
                selected.showOutline();
            }
        }
 
        


        showTargetText.text = "Hide Targets";
    }

    public void HideTargets()
    {
        for (int i = 0; i < ability.attack.Length; i++)
        {
            for (int j = 0; j < ability.attack[i].targets.Length; j++)
            {
                GameObject target = ability.allTargets[i][j];
                Selected selected = target.GetComponent<Selected>();
                selected.RemoveOutline();
            }
        }

        show.scrollText = null;
        showTargetText.text = "Show Targets";
    }


    public void DeleteAttack()
    {
        battle.abilities.Remove(ability);
        Destroy(gameObject);
        HideTargets();
    }
}
