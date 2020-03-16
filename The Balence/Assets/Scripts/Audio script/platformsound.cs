using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformsound : MonoBehaviour
{

    public AudioSource sound;
    public AudioClip platformSfx;


   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            //sound.Play();
            sound.PlayOneShot(platformSfx);

        }
        if (Input.GetKeyDown("d"))
        {
            //sound.Play();   
            sound.PlayOneShot(platformSfx);
        }
    }
}
