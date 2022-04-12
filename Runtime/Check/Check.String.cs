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
using System.IO;
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
    /// Comprueba que la cadena no sea null ni vacia.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="member"></param>
    /// <param name="sourceFile"></param>
    /// <param name="line"></param>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void IsNotNullOrEmpty(string value, [CallerMemberName]string member = "",
                                                    [CallerFilePath]string sourceFile = "",
                                                    [CallerLineNumber]int line = 0) =>
      Assert(string.IsNullOrEmpty(value) == false, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} '{nameof(value)}' is null or empty.");

    /// <summary>
    /// Comprueba que la cadena tenga una longitud exacta.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="len"></param>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void Length(string value, int len, [CallerMemberName]string member = "",
                                                     [CallerFilePath]string sourceFile = "",
                                                     [CallerLineNumber]int line = 0) =>
      Assert(value.Length == len, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} Expected string '{nameof(value)}' length must be {len.ToString()}.");

    /// <summary>
    /// Comprueba que la cadena tenga una longitud maxima.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="maxLength"></param>
    /// <param name="member"></param>
    /// <param name="sourceFile"></param>
    /// <param name="line"></param>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void MaxLength(string value, int maxLength, [CallerMemberName]string member = "",
                                                              [CallerFilePath]string sourceFile = "",
                                                              [CallerLineNumber]int line = 0) =>
      Assert(value.Length <= maxLength, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} Expected string '{nameof(value)}' max length must be {maxLength.ToString()}.");

    /// <summary>
    /// Comprueba que la cadena tenga una longitud mimina.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="minLength"></param>
    /// <param name="member"></param>
    /// <param name="sourceFile"></param>
    /// <param name="line"></param>
    /// <remarks>Only executed if UNITY_ASSERTIONS is defined.</remarks>
    [DebuggerStepThrough, Conditional("UNITY_ASSERTIONS")]
    public static void MinLength(string value, int minLength, [CallerMemberName]string member = "",
                                                              [CallerFilePath]string sourceFile = "",
                                                              [CallerLineNumber]int line = 0) =>
      Assert(value.Length >= minLength, $"{Path.GetFileName(sourceFile)}:{line.ToString()} {member} Expected string '{nameof(value)}' min length must be {minLength.ToString()}.");
  }
}