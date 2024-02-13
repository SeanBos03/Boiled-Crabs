using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;
using TiledMapParser;

/*
 *A platform like in the game icy tower
 */
public class Platform : AnimationSpriteCustom
{
    public Platform(string filenName, int rows, int columns, TiledObject obj = null) : base(filenName, rows, columns, obj)
    {
    }
}