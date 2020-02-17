using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceFoodState : MonoBehaviour
{
    public int FoodStateID;
    FoodStates foodstate;
    public GameObject associated;
    // Start is called before the first frame update
    void Start()
    {
        foodstate = GameObject.FindGameObjectWithTag("GameManager").GetComponent<FoodStates>();
    }

    // Update is called once per frame
    void Update()
    {
        if(FoodStateID == foodstate.currentFoodState)
        {
            associated.SetActive(true);
        }
        else
        {
            associated.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "LoseCondition" && FoodStateID == foodstate.currentFoodState)
        {

            collision.GetComponent<FoodTimer>().startfilling();


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "LoseCondition" && FoodStateID == foodstate.currentFoodState)
        {
            collision.GetComponent<FoodTimer>().stopFilling();
        }
    }

}
