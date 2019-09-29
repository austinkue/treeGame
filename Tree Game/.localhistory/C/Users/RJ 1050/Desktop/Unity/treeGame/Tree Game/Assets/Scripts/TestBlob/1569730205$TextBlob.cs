using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBlob : MonoBehaviour
{
    private static TextBlob textBlob;

    private void Awake()
    {
        textBlob = this;
        DontDestroyOnLoad(gameObject);
    }

    public static void SetMessage(string message)
    {

    }
}