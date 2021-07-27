using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TargetScript
{
    public GameObject[] Selected() 
    {
        GameObject[] taggedenemies = GameObject.FindGameObjectsWithTag("TaggedEnemy");
        for (int i = 0; i < taggedenemies.Length; i++)
        {
            Debug.Log(taggedenemies[i]);
        }

        foreach (GameObject _taggedEnemy in taggedenemies)
        {
            _taggedEnemy.tag = "Enemy";
        }

        return taggedenemies;
    }
    public void frontRow()
    {

    }

    public void middleRow()
    {

    }

    public void backRow()
    {

    }

    public void straight()
    {

    }

    public void diagonal()
    {

    }

    public GameObject[] all()
    {
 
        return GameObject.FindGameObjectsWithTag("Enemy");
    }


}
