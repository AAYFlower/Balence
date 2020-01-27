using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStates : MonoBehaviour
{
    public int currentFoodState;
    public GameObject Win;
    

    // Start is called before the first frame update
    void Start()
    {
        currentFoodState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFoodState == 3)
        {
            Win.SetActive(true);
        }
    }

    public void advanceState()
    {
        currentFoodState += 1;
    }
}
