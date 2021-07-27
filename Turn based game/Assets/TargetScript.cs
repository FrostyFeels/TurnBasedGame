using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TargetScript
{
    


    public GameObject[] Selected(AbilityTargeting target) 
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
        Debug.Log(target);

        return taggedenemies;
   
    }
    public GameObject[] FrontRow()
    {
        WallTargeting leftWall = GameObject.Find("Left").GetComponent<WallTargeting>();
        return leftWall.targets.ToArray();
    }

    public GameObject[] MiddleRow()
    {
        WallTargeting leftWall = GameObject.Find("Middle").GetComponent<WallTargeting>();
        return leftWall.targets.ToArray();
    }

    public GameObject[] BackRow()
    {
        WallTargeting leftWall = GameObject.Find("Right").GetComponent<WallTargeting>();
        return leftWall.targets.ToArray();
    }

    public GameObject[] Straight()
    {
       
        return GameObject.FindGameObjectsWithTag("Enemy"); ;
    }

    public void Diagonal()
    {

    }

    public GameObject[] all()
    {
        return GameObject.FindGameObjectsWithTag("Enemy");
    }


}
