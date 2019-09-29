using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBlob : MonoBehaviour
{
    private static TextBlob textBlob;
    private SpriteRenderer renderer;

    private void Awake()
    {
        textBlob = this;
        DontDestroyOnLoad(gameObject);
    }

    public static void SetMessage(string messageGraphic)
    {
        Sprite sprite = Resources.Load<Sprite>(messageGraphic);

    }

    private void _SetMessage(string messageGraphic)
    {
        Sprite sprite = Resources.Load<Sprite>(messageGraphic);
        renderer.sprite = sprite;
    }
}