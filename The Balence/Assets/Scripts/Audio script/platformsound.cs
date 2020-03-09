using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformsound : MonoBehaviour
{

    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            sound.Play();
        }
        if(Input.GetKeyDown("d"))
        {
            sound.Play();   
        }
    }
}
