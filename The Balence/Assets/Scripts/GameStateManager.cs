using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject GameWinCanvas;
    public GameObject LoseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        GameWinCanvas.SetActive(false);
        LoseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerWin()
    {
        GameWinCanvas.SetActive(true);
    }

    public void PlayerLose()
    {
        LoseCanvas.SetActive(true);
        Debug.Log("PlayerLose");
    }

}
