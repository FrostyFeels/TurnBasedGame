using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class AbilityAttack
{
    

    public float statChange;

    
    public enum attackType
    {
        damage,
        heal,
        vision,
        armor,
        cdReduction
    }

    public attackType type;

    public GameObject[] target;

    public void DoAttack(GameObject[] targets)
    {
        Debug.Log(targets[0]);
        target = targets;

        switch (type)
        {
            case attackType.damage:
                DoDamage();
                break;
            case attackType.heal:
                DoHeal();
                break;
            case attackType.vision:
                Dovision();
                break;
            case attackType.armor:
                DoArmor();
                break;
            case attackType.cdReduction:
                DoCdReduction();
                break;
        }
    }

    public void DoDamage()
    {
        foreach (GameObject _target in target)
        {
            CharacterHealth health = _target.GetComponent<CharacterHealth>();
            health.health -= statChange;
        }
    }

    public void DoHeal()
    {
        foreach (GameObject _target in target)
        {
            CharacterHealth health = _target.GetComponent<CharacterHealth>();
            health.health += statChange;
        }
    }

    public void Dovision()
    {
        foreach (GameObject _target in target)
        {
            CharacterHealth health = _target.GetComponent<CharacterHealth>();
            health.health += statChange;
        }
    }

    public void DoArmor()
    {
        foreach (GameObject _target in target)
        {
            CharacterHealth health = _target.GetComponent<CharacterHealth>();
            health.armor += statChange;
        }
    }

    public void DoCdReduction()
    {
        foreach (GameObject _target in target)
        {
            CharacterHealth health = _target.GetComponent<CharacterHealth>();
            health.health += statChange;
        }
    }
}
