using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    float peopleEaten;
    public Sprite[] dragonsprite;
    SpriteRenderer sr;
    int dragonLevel;
    GameStateManager gameState;
    Rigidbody2D rb;
    public bool movingright;
    public float speed;
    public GameObject blood;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        gameState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
        peopleEaten = 0;
        dragonLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(movingright == true)
        {
            rb.velocity = transform.right * speed;
        }

        if(movingright == false)
        {
            rb.velocity = -transform.right * speed;
        }
        if(peopleEaten >= 2)
        {
            dragonLevel += 1;
            peopleEaten = 0;
            ChangeSprite();
        }
        if (dragonLevel == 3)
        {
            gameState.PlayerWin();
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
    void ChangeSprite(){
        sr.sprite = dragonsprite[dragonLevel];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            movingright = !movingright;
            Vector3 newScale = gameObject.transform.localScale;
            newScale.x *= -1;
            gameObject.transform.localScale = newScale;
        }

        if (collision.gameObject.tag == "Peasent")
        {
            peopleEaten += 1;
            Instantiate(blood, transform.position, transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}
