using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class ChangeScrollbarText : MonoBehaviour
{
    public Ability ability;
    public TextMeshProUGUI name;
    public TextMeshProUGUI describtion;

    private void Start()
    {
        name.text = ability.name;
        describtion.text = ability.description;
    }
}
