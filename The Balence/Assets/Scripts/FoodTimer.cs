using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodTimer : MonoBehaviour
{
    public GameObject fillbar;
    public Image bar;
    public float filltimer;
    public bool isfilling;
    private float timer;
    FoodStates foodstate;

    // Start is called before the first frame update
    void Start()
    {
        isfilling = false;
        
        foodstate = GameObject.FindGameObjectWithTag("GameManager").GetComponent<FoodStates>();
        fillbar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isfilling == true)
        {
            timer += 1 * Time.deltaTime;
        }
        bar.fillAmount = (timer / filltimer);


        if(timer >= filltimer)
        {
            isfilling = false;
            timer = 0;
            foodstate.advanceState();
            fillbar.SetActive(false);
            
            
        }
    }



    public void startfilling()
    {
        fillbar.SetActive(true);
        isfilling = true;

    }

    public void stopFilling()
    {
        fillbar.SetActive(false);
        isfilling = false;
        timer = 0;
    }


}
