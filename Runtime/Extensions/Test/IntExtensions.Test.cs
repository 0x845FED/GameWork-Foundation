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
using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using FronkonGames.GameWork.Foundation;
using UnityEditor.VersionControl;
using UnityEngine;

/// <summary>
/// Extensions test.
/// </summary>
public partial class ExtensionsTests
{
  /// <summary>
  /// IntExtensions test.
  /// </summary>
  [UnityTest]
  public IEnumerator Int()
  {
    Assert.AreEqual(0.Max(1), 1);
    Assert.AreEqual(1.Max(0), 1);
    Assert.AreEqual(1.Max(-1), 1);
    Assert.AreEqual(0.Min(1), 0);
    Assert.AreEqual(1.Min(0), 0);
    Assert.AreEqual(1.Min(-1), -1);

    Assert.AreEqual(0.Abs(), 0);
    Assert.AreEqual(1.Abs(), 1);
    Assert.AreEqual((-1).Abs(), 1);

    Assert.AreEqual(1.Clamp(0, 2), 1);
    Assert.AreEqual((-1).Clamp(0, 2), 0);
    Assert.AreEqual(3.Clamp(0, 2), 2);

    Assert.AreEqual(0.Pow(1), 0);
    Assert.AreEqual(1.Pow(0), 1);
    Assert.AreEqual(2.Pow(1), 2);
    Assert.AreEqual(2.Pow(2), 4);

    Assert.IsTrue(0.Between(-1, 1));
    Assert.IsTrue(1.Between(-1, 1));
    Assert.IsTrue((-1).Between(-1, 1));
    Assert.IsFalse(2.Between(-1, 1));
    Assert.IsFalse((-2).Between(-1, 1));

    Assert.IsFalse(0.IsOdd());
    Assert.IsTrue(1.IsOdd());
    Assert.IsFalse(2.IsOdd());

    Assert.AreEqual(0.NextPowerOfTwo(), 0);
    Assert.AreEqual(1.NextPowerOfTwo(), 1);
    Assert.AreEqual(2.NextPowerOfTwo(), 2);
    Assert.AreEqual(3.NextPowerOfTwo(), 4);
    Assert.AreEqual(4.NextPowerOfTwo(), 4);

    LayerMask layerMaskTest = LayerMask.NameToLayer("Test");
    int maskTest = LayerMask.NameToLayer("Test");
    Assert.IsTrue(maskTest.IsInLayerMask(Physics.AllLayers));

    Assert.AreEqual(1024.BytesToHumanReadable(), "1.00 KB");
    Assert.AreEqual((1024 * 1024).BytesToHumanReadable(), "1.00 MB");

    Assert.AreEqual(60.SecondsToHumanReadable(), "00:01:00");
    Assert.AreEqual(3600.SecondsToHumanReadable(), "01:00:00");

    yield return null;
  }
}