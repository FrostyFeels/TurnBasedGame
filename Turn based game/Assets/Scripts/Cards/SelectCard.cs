using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{
    public Ability ability;

    private void OnMouseDown()
    {
        ability.ReturnTargets(0);
    }



}
