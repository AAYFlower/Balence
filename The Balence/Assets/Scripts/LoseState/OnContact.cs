using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnContact : MonoBehaviour
{

    GameStateManager gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("LoseCondition"))
        {
            gameState.PlayerLose();
            Destroy(collision.gameObject);
        }
    }
}
