using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaGraphic : MonoBehaviour
{
    private static Dictionary<Enum, PermaGraphic> graphic;
    new private SpriteRenderer renderer;

    private enum GraphicIdent
    {
        main
    }

    public GraphicIdent identifier;

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