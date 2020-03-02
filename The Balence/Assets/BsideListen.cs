using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BsideListen : MonoBehaviour
{
    BSideUnlock bu;
    public GameObject BsideCanvas;
    // Start is called before the first frame update
    void Start()
    {
        bu = GameObject.FindGameObjectWithTag("BSide").GetComponent<BSideUnlock>();
        if(bu.BSideUnlocked == true)
        {
            BsideCanvas.SetActive(true);
        }
        else
        {
            BsideCanvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
