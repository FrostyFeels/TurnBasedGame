using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESM_Colum : ESM_Main
{
    public GameObject[] attackLocations;
    public GameObject[] raycastLocations;
    public List<GameObject> targets;

    public override void GetTargets(AbilityTargeting target, int numberOfTargets)
    {
        base.GetTargets(target, numberOfTargets);

        foreach (GameObject _location in attackLocations)
        {
            _location.SetActive(true);
        }
    }

    public void RunRayCast()
    {
        foreach (GameObject _attackLocation in raycastLocations)
        {
            RaycastHit2D[] ray = Physics2D.RaycastAll(_attackLocation.transform.position, new Vector2(0, -1), 10000f);
            Debug.DrawRay(_attackLocation.transform.position, new Vector2(1, 0), Color.white, 3600);

            if (ray.Length != 0)
            {
                for (int i = 0; i < ray.Length; i++)
                {
                    targets.Add(ray[i].transform.gameObject);
                }
            }
        }

        SendTargets();
    }


    public override void SendTargets()
    {
        base.SendTargets();

        targeting.targets = targets.ToArray();
    }

    public void Update()
    {
        targetsSelected = EnemySelectorManager.targetsSelected;
        if (targetsSelected >= targetsRequired && run)
        {
            raycastLocations = GameObject.FindGameObjectsWithTag("ChosenTarget");

            foreach (GameObject _location in attackLocations)
            {
                _location.SetActive(false);
            }
            RunRayCast();
            run = false;
        }
    }
}
