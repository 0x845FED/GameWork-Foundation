////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FronkonGames.GameWork.Foundation
{
  /// <summary>
  /// Checks values and throws an exception if the condition is not met.
  /// </summary>
  public static partial class Check
  {
    /// <summary>
    /// Comprueba que el valor si sea null.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="member"></param>
    /// <param name="sourceFile"></param>
    /// <param name="line"></param>
    /// <typeparam name="T"></typeparam>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void IsNull<T>(T value, [CallerMemberName]string member = "",
                                        [CallerFilePath]string sourceFile = "",
                                        [CallerLineNumber]int line = 0) =>
      Assert(value == null, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} '{nameof(value)}' must be null.");

    /// <summary>
    /// Comprueba que el valor no sea null.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="member"></param>
    /// <param name="sourceFile"></param>
    /// <param name="line"></param>
    /// <typeparam name="T"></typeparam>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void IsNotNull<T>(T value, [CallerMemberName]string member = "",
                                             [CallerFilePath]string sourceFile = "",
                                             [CallerLineNumber]int line = 0) =>
      Assert(value != null, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} '{nameof(value)}' must not be null.");

    /// <summary>
    /// Comprueba que la colección no sea null o este vacia.
    /// </summary>
    /// <param name="collection"></param>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void IsNotNullOrEmpty<T>(ICollection<T> collection, [CallerMemberName]string member = "",
                                                                      [CallerFilePath]string sourceFile = "",
                                                                      [CallerLineNumber]int line = 0) =>
      Assert(collection != null && collection.Count > 0, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} '{nameof(collection)}' cant be null or empty.");

    /// <summary>
    /// El objecto es del tipo type.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="type"></param>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void OfType(object obj, Type type, [CallerMemberName]string member = "",
                                                     [CallerFilePath]string sourceFile = "",
                                                     [CallerLineNumber]int line = 0) =>
      Assert(type != null && obj != null && type.IsInstanceOfType(obj) == true, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} '{nameof(obj)}' must be of type '{type?.Name}'.");
  }
}
