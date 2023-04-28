using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

public static class ResourceManager
{
    static List<Texture2D> sprites;

    static ResourceManager()
    {
        sprites = new List<Texture2D>();
    }

    public static void AddSprite(Texture2D sp)
    {
        sprites.Add(sp);
    }

    public static Texture2D FindSprite(string name)
    {
        for (int i = 0; i < sprites.Count; ++i)
        {
            if (sprites[i].Name == name)
            {
                return sprites[i];
            }
        }

        throw new FormatException("No sprite with name " + name + " exists.");
    }
}