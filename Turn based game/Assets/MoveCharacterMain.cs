using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoveCharacterMain : MonoBehaviour
{
    public GameObject[] moveCharacters;
    public GameObject text;

    public void ShowSwapObjects()
    {
        text.SetActive(true);
        for (int i = 0; i < moveCharacters.Length; i++)
        {
            moveCharacters[i].SetActive(true);
        }
    }

    public void HideSwapObject()
    {
        text.SetActive(false);
        for (int i = 0; i < moveCharacters.Length; i++)
        {
            moveCharacters[i].SetActive(false);
        }
    }
}
