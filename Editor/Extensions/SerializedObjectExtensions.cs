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
using UnityEngine;
using UnityEditor;

namespace FronkonGames.GameWork.Foundation
{
  /// <summary>
  /// SerializedObject extensions.
  /// </summary>
  public static class SerializedObjectExtensions
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="name"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    public static bool BoolField(this SerializedObject self, string name, string label = "")
    {
      SerializedProperty property = self.FindProperty(name);
      BoolAttribute attribute = self.targetObject.GetAttribute<BoolAttribute>(name);
      if (property != null && attribute != null)
      {
        EditorGUILayout.BeginHorizontal();
        {
          EditorGUILayout.PropertyField(property, Inspector.NewGUIContent(label, name, attribute.tooltip));

          if (Inspector.ResetButton() == true)
            property.boolValue = attribute.defaultValue;
        }
        EditorGUILayout.EndHorizontal();

        return property.boolValue;
      }

      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="name"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    public static int IntField(this SerializedObject self, string name, string label = "")
    {
      SerializedProperty property = self.FindProperty(name);
      IntAttribute attribute = self.targetObject.GetAttribute<IntAttribute>(name);
      if (property != null && attribute != null)
      {
        EditorGUILayout.BeginHorizontal();
        {
          EditorGUILayout.PropertyField(property, Inspector.NewGUIContent(label, name, attribute.tooltip));

          if (Inspector.ResetButton() == true)
            property.intValue = attribute.defaultValue;

          if (attribute.min < attribute.max)
            property.intValue = property.intValue.Clamp(attribute.min, attribute.max);
        }
        EditorGUILayout.EndHorizontal();

        return property.intValue;
      }

      return 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="name"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    public static float FloatField(this SerializedObject self, string name, string label = "")
    {
      SerializedProperty property = self.FindProperty(name);
      FloatAttribute attribute = self.targetObject.GetAttribute<FloatAttribute>(name);
      if (property != null && attribute != null)
      {
        EditorGUILayout.BeginHorizontal();
        {
          EditorGUILayout.PropertyField(property, Inspector.NewGUIContent(label, name, attribute.tooltip));

          if (Inspector.ResetButton() == true)
            property.floatValue = attribute.defaultValue;

          if (attribute.min < attribute.max)
            property.floatValue = property.floatValue.Clamp(attribute.min, attribute.max);
        }
        EditorGUILayout.EndHorizontal();

        return property.floatValue;
      }

      return 0.0f;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="name"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    public static float SliderField(this SerializedObject self, string name, string label = "")
    {
      SerializedProperty property = self.FindProperty(name);
      SliderAttribute attribute = self.targetObject.GetAttribute<SliderAttribute>(name);
      if (property != null && attribute != null)
      {
        EditorGUILayout.BeginHorizontal();
        {
          if (attribute.floatSlider == true)
          {
            property.floatValue = EditorGUILayout.Slider(Inspector.NewGUIContent(label, name, attribute.tooltip), property.floatValue, attribute.min, attribute.max);

            if (Inspector.ResetButton() == true)
              property.floatValue = attribute.defaultValue;
          }
          else
          {
            property.intValue = EditorGUILayout.IntSlider(Inspector.NewGUIContent(label, name, attribute.tooltip), property.intValue, (int)attribute.min, (int)attribute.max);

            if (Inspector.ResetButton() == true)
              property.intValue = (int)attribute.defaultValue;
          }
        }
        EditorGUILayout.EndHorizontal();

        return attribute.floatSlider == true ? property.floatValue : property.intValue;
      }

      return 0.0f;
    }    
  }
}
