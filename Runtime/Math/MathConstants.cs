﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Martin Bustos @FronkonGames <fronkongames@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of
// the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using UnityEngine;

namespace FronkonGames.GameWork.Foundation
{
  /// <summary>
  /// Math constants.
  /// </summary>
  public struct MathConstants
  {
    public static readonly float Pi            = 3.14159265358979f;
    public static readonly float PiHalf        = Pi * 0.5f;
    public static readonly float Pi2           = Pi * 2.0f;
    public static readonly float E             = 2.71828182846f;
    public static readonly float Tau           = 6.28318530717959f;
    public static readonly float GoldenRation  = 1.61803398875f;

    public static readonly float Deg2Rad  = Tau / 360.0f;
    public static readonly float Rad2Deg  = 360.0f / Tau;

    public static readonly float Epsilon           = Mathf.Epsilon;
    public static readonly float Infinity          = Mathf.Infinity;
    public static readonly float NegativeInfinity  = Mathf.NegativeInfinity;

    public static readonly Vector2 NaNVector2      = new Vector2(float.NaN, float.NaN);
    public static readonly Vector2 InfinityVector2 = new Vector2(Infinity, Infinity);
    
    public static readonly Vector3 NaNVector3      = new Vector3(float.NaN, float.NaN, float.NaN);
    public static readonly Vector3 InfinityVector3 = new Vector3(Infinity, Infinity, Infinity);

    public static readonly Vector4 NaNVector4      = new Vector4(float.NaN, float.NaN, float.NaN, float.NaN);
    public static readonly Vector3 InfinityVector4 = new Vector4(Infinity, Infinity, Infinity, Infinity);
    
    public static readonly Ray EmptyRay = new Ray();
  }
}