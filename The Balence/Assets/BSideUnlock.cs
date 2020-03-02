using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSideUnlock : MonoBehaviour
{
    public bool BSideUnlocked;
    // Start is called before the first frame update
    void Start()
    {
        BSideUnlocked = false;
    
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void UnlockBSide()
    {
        BSideUnlocked = true;
    }
}
