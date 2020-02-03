using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int health;
    public GameObject particle;
    bool damaged;
    GameStateManager gameState;
    public bool isPlayer;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
        damaged = false;
        particle.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(damaged == true && particle != null)
        {
           
            particle.SetActive(true);
        }

        if(health <= 0)
        {
            die();
        }
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        damaged = true;
        
    }
    void die()
    {
        if(isPlayer== false)
        gameState.PlayerWin();
        Destroy(gameObject);

        if(isPlayer == true)
        {
            gameState.PlayerLose();
        }
    }

  
}
