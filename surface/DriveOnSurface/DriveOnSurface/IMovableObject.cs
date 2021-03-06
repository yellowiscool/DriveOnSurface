﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DriveOnSurface
{
    /**
     * Interface pour les objets déplaçables.
     **/
    interface IMovableObject : IDrawableObject
    {
        Vector2 getPosition();

        void setPosition(Vector2 Pos);

        void setPosition(int X, int Y);

        float getRotation();

        void setRotation(float Rot);        

    }
}