using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AcornPanelAction : MonoBehaviour
{
    //this is for main scene
    public GameObject roots2,AcornPanel, AcornPanelHead,AcornPanelLeft, AcornPanelRight, AcornPanelLegs, rodentKO, Button1;
    // Start is called before the first frame update
    void Start()
    {
        AcornPanelHead.SetActive(false);
        AcornPanelLeft.SetActive(false);
        rodentKO.SetActive(false);
        roots2.SetActive(false);
    }

    public void LightOnFire()
    {
        AcornPanelHead.SetActive(true);
        
        Time.timeScale = 0;
    }
    
    public void AlexJones()
    {
        AcornPanelLeft.SetActive(true);
        rodentKO.SetActive(true);
        Time.timeScale = 1;
    }
    public void roots()
    {
        roots2.SetActive(true);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
