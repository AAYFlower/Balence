using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobaTop : MonoBehaviour
{
    GameStateManager gameState;
    public SpriteRenderer bobstraw;
    public Sprite sadBoba;
    public Sprite emptyHand;
    public SpriteRenderer sr;
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
        if(collision.gameObject.tag == "Hand")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = emptyHand;
            sr.sprite = sadBoba;
            gameState.PlayerWin();
        }
    }

}
