using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{

    public Sprite[] plantSprites;
    int plantLevel;
    public float GrowthAmountNeeded;
    float growth;
    SpriteRenderer sr;
    bool growing;
    GameStateManager gameState;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        gameState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
        plantLevel = 0;
        growing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(growing == true)
        {
            growth += 1 * Time.deltaTime;
        }


        if(growth >= GrowthAmountNeeded)
        {
            growth = 0;
            plantLevel += 1;
            sr.sprite = plantSprites[plantLevel];

        }

        if(plantLevel == plantSprites.Length)
        {
            Debug.Log("win");
            gameState.PlayerWin();
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Rain")
        {
            growing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Rain")
        {
            growing = false;
        }
    }

}
