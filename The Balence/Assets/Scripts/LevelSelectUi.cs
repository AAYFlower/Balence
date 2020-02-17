using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectUi : MonoBehaviour
{

    public GameObject levelSelect;
    // Start is called before the first frame update
    void Start()
    {
        levelSelect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void EnableLevelCanvas()
    {
        levelSelect.SetActive(true);
    }

    public void disableLevelCanvas()
    {
        levelSelect.SetActive(false);
    }

}
