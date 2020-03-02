using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnContact : MonoBehaviour
{

    GameStateManager gameState;
    public UnityEvent loseEvent;
    public bool destroyOncontact = true;
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
            loseEvent.Invoke();
            if (destroyOncontact == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
