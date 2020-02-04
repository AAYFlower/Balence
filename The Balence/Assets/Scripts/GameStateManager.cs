using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject GameWinCanvas;
    public GameObject LoseCanvas;
    bool PlayerobjStatus;
    // Start is called before the first frame update
    void Start()
    {
        GameWinCanvas.SetActive(false);
        LoseCanvas.SetActive(false);
        PlayerobjStatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerWin()
    {
        if (PlayerobjStatus == false)
        {
            PlayerobjStatus = true;
            GameWinCanvas.SetActive(true);
        }
    }

    public void PlayerLose()
    {
        if (PlayerobjStatus == false)
        {
            PlayerobjStatus = true;
            LoseCanvas.SetActive(true);
            Debug.Log("PlayerLose");
        }
    }

}
