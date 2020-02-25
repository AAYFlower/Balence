using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public Animator anim;
    bool menuOpen;
    // Start is called before the first frame update
    void Start()
    {
        menuOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMenu()
    {
        menuOpen = !menuOpen;
        anim.SetBool("Menu", menuOpen);
    }
}
