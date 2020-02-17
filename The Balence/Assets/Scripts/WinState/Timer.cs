using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    GameStateManager gameState;
    public float timer;
    public Text TimerText;
    public bool isloseCondition;
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
            TimerText.text = timer.ToString("F1");
        }

        if (timer <= 0)
        {

            if (isloseCondition == false)
            {
                gameState.PlayerWin();
                TimerText.gameObject.SetActive(false);
            }
            if(isloseCondition == true)
            {
                gameState.PlayerLose();
                TimerText.gameObject.SetActive(false);
            }
        }
    }
}
