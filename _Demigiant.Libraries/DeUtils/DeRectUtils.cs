﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2015/12/15 18:37
// License Copyright (c) Daniele Giardini

using System;
using UnityEngine;

namespace DG.DeUtils
{
    /// <summary>
    /// Utils for structs
    /// </summary>
    public static class DeRectUtils
    {
        /// <summary>
        /// Adds one rect into another, and returns the resulting a
        /// </summary>
        [Obsolete("DeRectUtils.Add is deprecated, use the myRect.Add extension instead (in the DeExtensions library).")]
        public static Rect Add(Rect a, Rect b)
        {
            if (b.xMin < a.xMin) a.xMin = b.xMin;
            if (b.xMax > a.xMax) a.xMax = b.xMax;
            if (b.yMin < a.yMin) a.yMin = b.yMin;
            if (b.yMax > a.yMax) a.yMax = b.yMax;
            return a;
        }

        /// <summary>
        /// Resizes the given Rect so it fits proportionally within the given size limits
        /// </summary>
        /// <param name="r">Rect target</param>
        /// <param name="w">Width to fit</param>
        /// <param name="h">Height to fit</param>
        /// <param name="shrinkOnly">If TRUE (default) only shrinks the rect if needed, if FALSE also enlarges it to fit</param>
        /// <returns></returns>
        [Obsolete("DeRectUtils.Fit is deprecated, use the myRect.Fit extension instead (in the DeExtensions library).")]
        public static Rect Fit(Rect r, float w, float h, bool shrinkOnly = true)
        {
            if (shrinkOnly && r.width <= w && r.height <= h) return r;
            float wPerc = w / r.width;
            float hPerc = h / r.height;
            float perc = wPerc < hPerc ? wPerc : hPerc;
            r.width *= perc;
            r.height *= perc;
            return r;
        }

        /// <summary>
        /// Returns TRUE if the first rect fully includes the second one
        /// </summary>
        [Obsolete("DeRectUtils.Includes is deprecated, use the myRect.Includes extension instead (in the DeExtensions library).")]
        public static bool Includes(Rect a, Rect b)
        {
            return a.xMin <= b.xMin && a.xMax > b.xMax && a.yMin <= b.yMin && a.yMax >= b.yMax;
        }

        /// <summary>
        /// Modifies and returns the given Rect, with its values shifted according the the given parameters
        /// </summary>
        [Obsolete("DeRectUtils.Shift is deprecated, use the myRect.Shift extension instead (in the DeExtensions library).")]
        public static Rect Shift(Rect rect, float x, float y, float width, float height)
        {
            return new Rect(rect.x + x, rect.y + y, rect.width + width, rect.height + height);
        }
    }
}