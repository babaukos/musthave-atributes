/*
* Usage: simply put a Attribute in front of your variables like this:
*
*     [AdditionalText("m/s")]
*     public float velocity = 20f;
*/

using UnityEditor;
using UnityEngine;
  
[CustomPropertyDrawer(typeof(AdditionalTextAttribute))]
public class AdditionalTextDrawer : PropertyDrawer
{
  private static GUIStyle auditStyle
  {
    get
    {
      var style = new GUIStyle(EditorStyles.label);
      style.alignment = TextAnchor.MiddleRight;
      style.normal.textColor = Color.gray;
      return style;
    }
  }
  
  public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
  {
    var attrib = attribute as AdditionalTextAttribute;
    EditorGUI.PropertyField(position, property, label);

      
    GUI.Label(position, attrib.Text, auditStyle);
  }
}
