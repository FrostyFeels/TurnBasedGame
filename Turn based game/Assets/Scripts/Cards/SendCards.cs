using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCards : MonoBehaviour
{
    public Ability[] abilities;
    public GetCards getCards;

    public void Start()
    {
        abilities = gameObject.GetComponentsInChildren<Ability>();
    }
    public void OnMouseDown()
    {
        getCards.abilities = abilities;
        getCards.SetCardsActive();
    }

}
