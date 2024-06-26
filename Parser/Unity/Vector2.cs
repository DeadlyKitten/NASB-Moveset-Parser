﻿namespace MovesetParser.Unity
{
    public struct Vector2
    {
        public static Vector2 zero => zeroVector;
        private static readonly Vector2 zeroVector = new Vector2(0, 0);

        public float x, y;

        public Vector2 (float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
