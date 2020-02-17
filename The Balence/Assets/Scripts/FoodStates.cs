using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStates : MonoBehaviour
{
    public int currentFoodState;

    GameStateManager gameState;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
        currentFoodState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFoodState == 3)
        {
            gameState.PlayerWin();
        }
    }

    public void advanceState()
    {
        currentFoodState += 1;
    }
}
