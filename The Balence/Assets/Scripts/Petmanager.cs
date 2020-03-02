using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petmanager : MonoBehaviour
{
    int amountofFish;
    GameStateManager gsm;
    public bool isAlter = false;
    // Start is called before the first frame update
    void Start()
    {
        gsm = GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(amountofFish <= 0)
        {
            gsm.PlayerWin();
        }
    }

    public void addFish()
    {
        amountofFish += 1;
    }

    public void SubtractFish()
    {
        amountofFish -= 1;
        if(isAlter == true)
        {
            gsm.PlayerLose();
        }
    }

}
