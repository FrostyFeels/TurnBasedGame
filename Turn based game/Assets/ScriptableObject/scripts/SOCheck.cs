using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOCheck : MonoBehaviour
{
    public SOTest test;
    public TextMeshProUGUI text;


    public void AddNumber()
    {
        test.number++;
        text.text = test.number.ToString();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
