using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTest : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            PermaGraphic.SetMessage(PermaGraphic.GraphicIdent.main, "testGraphic");
        }
    }
}
