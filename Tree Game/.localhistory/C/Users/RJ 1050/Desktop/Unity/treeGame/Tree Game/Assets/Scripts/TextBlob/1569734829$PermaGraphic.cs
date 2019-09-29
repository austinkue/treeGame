using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaGraphic : MonoBehaviour
{
    private static Dictionary<Enum, PermaGraphic> dic;
    new private SpriteRenderer renderer;

    public enum GraphicIdent
    {
        main
    }

    public GraphicIdent identifier;

    private void Start()
    {
        dic.Add(identifier, this);
        DontDestroyOnLoad(gameObject);
        renderer = gameObject.AddComponent<SpriteRenderer>();
    }

    public static void SetMessage(GraphicIdent identifier, string messageGraphic)
    {
        dic[identifier]?._SetMessage(messageGraphic);
    }

    private void _SetMessage(string messageGraphic)
    {
        Sprite sprite = Resources.Load<Sprite>(messageGraphic);
        renderer.sprite = sprite;
    }
}