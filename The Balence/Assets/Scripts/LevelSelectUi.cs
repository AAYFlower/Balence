using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectUi : MonoBehaviour
{

    public GameObject levelSelect;
    public GameObject levelSelect2;
    // Start is called before the first frame update
    void Start()
    {
        levelSelect.SetActive(false);
        levelSelect2.SetActive(false);
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

    public void EnableLevelCanvas2()
    {
        levelSelect2.SetActive(true);

    }

    public void disableLevelCanvas2()
    {
        levelSelect2.SetActive(false);
    }
}
