using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public bool swapping = false;
    public bool running = false;

    public float time;
    
    public Transform main;

    public MoveCharacter target;

    public Vector2 currentlocation;
    public Vector2 SwapLocation;

    public GameObject text;

    public void StartSwapping()
    {
        Debug.Log("WhY");

        BattleManager.gameState = BattleManager.GameState.swappingCharacters;
        text.SetActive(true); 
        swapping = true;
    }
    public void Update()
    {
        if(swapping && BattleManager.finishSwapping)
        {
            target = GameObject.FindGameObjectWithTag("Selected").GetComponent<MoveCharacter>();
            SwapLocation = target.main.position;
            currentlocation = main.position;
            Swap();
        }

        if (running)
        {
            time += Time.deltaTime / 1f;
            main.position = Vector3.Lerp(currentlocation, SwapLocation, time);
            target.main.position = Vector3.Lerp(SwapLocation, currentlocation, time);


            if (transform.position.x == SwapLocation.x && transform.position.y == SwapLocation.y)
            {
                running = false;
                time = 0;
                BattleManager.gameState = BattleManager.GameState.idle;
                target.tag = "ally";
            }
        }
    }
    public void Swap()
    {
        text.SetActive(false);

        running = true;
        swapping = false;
        BattleManager.finishSwapping = false;
    }
    public void OnMouseDown()
    {
        if(BattleManager.gameState == BattleManager.GameState.swappingCharacters && !swapping && gameObject.CompareTag("ally"))
        {
            BattleManager.finishSwapping = true;
            this.tag = "Selected";
        }

        if(BattleManager.gameState == BattleManager.GameState.idle)
        {
            StartSwapping();
        }
    }

}
