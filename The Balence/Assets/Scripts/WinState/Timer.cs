using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    GameStateManager gameState;
    public float timer;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        timer -= Time.deltaTime;

        if(TimerText != null)
        {
            TimerText.text = timer.ToString();
        }

        if (timer <= 0)
        {
            gameState.PlayerWin();
        }
    }
}
