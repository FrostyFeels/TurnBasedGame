using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    public SpriteRenderer outline;

    public void showOutline()
    {
        outline.enabled = true;
    }

    public void RemoveOutline()
    {
        outline.enabled = false;
    }
}
