using System;
using Microsoft.Xna.Framework;

namespace Ctrl_Space
{
    static class Chaos
    {
        private static Random _random = new Random();

        public static float GetFloat()
        {
            return (float)_random.NextDouble();
        }

        public static float GetFloat(float max)
        {
            return (float)(_random.NextDouble() * max);
        }

        public static float GetFloat(float min, float max)
        {
            return (float)(_random.NextDouble() * (max - min) + min);
        }

        public static Vector2 GetVector2()
        {
            float a = GetFloat(MathHelper.TwoPi);
            return new Vector2(Maf.Cos(a), Maf.Sin(a));
        }
    }
}
