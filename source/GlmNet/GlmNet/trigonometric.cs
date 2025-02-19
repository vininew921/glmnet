﻿using System;

namespace GlmNet
{
    // ReSharper disable InconsistentNaming
    public static partial class glm
    {
        public static float acos(float x) => (float)Math.Acos(x);

        public static float acosh(float x) => x < 1f ? 0f : (float)Math.Log(x + Math.Sqrt((x * x) - 1f));

        public static float asin(float x) => (float)Math.Asin(x);

        public static float asinh(float x) => (float)(x < 0f ? -1f : (x > 0f ? 1f : 0f)) * (float)Math.Log(Math.Abs(x) + Math.Sqrt(1f + (x * x)));

        public static float atan(float y, float x) => (float)Math.Atan2(y, x);

        public static float atan(float y_over_x) => (float)Math.Atan(y_over_x);

        public static float atanh(float x) => Math.Abs(x) >= 1f ? 0 : 0.5f * (float)Math.Log((1f + x) / (1f - x));

        public static float cos(float angle) => (float)Math.Cos(angle);

        public static float cosh(float angle) => (float)Math.Cosh(angle);

        public static float degrees(float radians) => radians * 57.295779513082320876798154814105f;

        public static float radians(float degrees) => degrees * 0.01745329251994329576923690768489f;

        public static float sin(float angle) => (float)Math.Sin(angle);

        public static float sinh(float angle) => (float)Math.Sinh(angle);

        public static float tan(float angle) => (float)Math.Tan(angle);

        public static float tanh(float angle) => (float)Math.Tanh(angle);
    }
}
