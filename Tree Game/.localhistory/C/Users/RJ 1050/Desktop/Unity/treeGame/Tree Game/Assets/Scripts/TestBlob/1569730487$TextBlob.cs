using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBlob : MonoBehaviour
{
    private static TextBlob textBlob;
    new private SpriteRenderer renderer;

    private void Awake()
    {
        textBlob = this;
        DontDestroyOnLoad(gameObject);
        renderer = gameObject.AddComponent<SpriteRenderer>();
    }

    public static void SetMessage(string messageGraphic)
    {
        textBlob?._SetMessage(messageGraphic);

    }

    private void _SetMessage(string messageGraphic)
    {
        Sprite sprite = Resources.Load<Sprite>(messageGraphic);
        renderer.sprite = sprite;
    }
}