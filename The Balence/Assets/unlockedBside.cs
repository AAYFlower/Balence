using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockedBside : MonoBehaviour
{
    BSideUnlock bu;
    // Start is called before the first frame update
    void Awake()
    {
        bu = GameObject.FindGameObjectWithTag("BSide").GetComponent<BSideUnlock>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlock()
    {
        bu.UnlockBSide();
    }
}
