using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTargeting : MonoBehaviour
{
    public List<GameObject> targets;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            targets.Add(collision.gameObject);
        }
    }
}
