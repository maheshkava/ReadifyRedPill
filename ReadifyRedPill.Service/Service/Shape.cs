using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Shape
/// </summary>
public class Shape
{
    /// <summary>
    ///  Determines the type of triangle based on the three provides sides.
    /// </summary>
    /// <param name="a">The length of side a</param>
    /// <param name="b">The length of side b</param>
    /// <param name="c">The length of side c</param>
    /// <returns></returns>
    public TriangleType WhatShapeIsThis(int a, int b, int c)
    {
        // If any side is invalid, then return error.
        if (a <= 0 || b <= 0 || c <= 0)
            return TriangleType.Error;

        // If all sides are equal, then return equilateral.
        if (a == b && b == c)
            return TriangleType.Equilateral;

        if ((a + b <= c) || (a + c <= b) || (c + b <= a))
            return TriangleType.Error;

        // if two equal sides must be greater than the third side, then return isosceles 
        if ((a != c && (a == b || b == c))
                 || (a == c && a != b))
            return TriangleType.Isosceles;

        // largest side must be less then the sum of the other two, return scalene
        if (a != b && b != c && a != c)
            return TriangleType.Scalene;

        return TriangleType.Error;
    }
}