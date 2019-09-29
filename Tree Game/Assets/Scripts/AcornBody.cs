using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornBody : MonoBehaviour
{

    /*
     AcornPanel is commented out for now.
     This is more of a template. 

        The head, left, right and legs of the acorn will be the ones with the most action going to happen to them.
        Acorn itself will be able to have things happen but that won't always be the case.
    
         */

    public GameObject AcornPanel, AcornPanelHead, AcornPanelLeft, AcornPanelRight, AcornPanelLegs;

    // Start is called before the first frame update
    void Start()
    {
        AcornPanel.SetActive(true);
        AcornPanelHead.SetActive(false);
        AcornPanelLeft.SetActive(false);
        AcornPanelRight.SetActive(false);
        AcornPanelLegs.SetActive(false);
    }
    /*
    what happens to acorn panel

        This is commented out for now, middle panel has acorn

    public void AcornPanelAction()
    {
        AcornPanel.SetActive(true);

        Time.timeScale = 0;
    }
    */
    public void AcornPanelHeadAction()
    {
        AcornPanelHead.SetActive(true);

        Time.timeScale = 0;
    }
    public void AcornPanelLeftAction()
    {
        AcornPanelLeft.SetActive(true);

        Time.timeScale = 0;
    }
    public void AcornPanelRightAction()
    {
        AcornPanelRight.SetActive(true);

        Time.timeScale = 0;
    }
    public void AcornPanelLeftRightSameAction()
    {
        AcornPanelRight.SetActive(true);
        AcornPanelLeft.SetActive(true);

        Time.timeScale = 0;
    }

    public void AcornPanelLegsAction()
    {
        AcornPanelLegs.SetActive(true);

        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
