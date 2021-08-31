using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCharacterClass : MonoBehaviour
{
    public CharacterStats stats;
    public SpriteRenderer _renderer;

    public void Start()
    {
        
    }
    public void ChangeStats()
    {
        Debug.Log("Runs");

        stats.SwapStats();
        _renderer.sprite = stats.currentStat.sprite;
    }

    public void OnMouseDown()
    {
        if (BattleManager.gameState == BattleManager.GameState.idle)
        {
            ChangeStats();
        }
    }
}
