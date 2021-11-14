/*
* Usage: simply put a Attribute in front of your variables like this:
*
*     [Comment("This is comment")]
*     public float velocity = 20f;
*/

using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(CommentAttribute))]
public class CommentDrawer : PropertyDrawer
{
    // Reference to the attribute on the property.
    private CommentAttribute attrib;
    private static GUIStyle commentStyle
    {
        get
        {
            var style = new GUIStyle(EditorStyles.helpBox);
            style.alignment = TextAnchor.MiddleCenter;
            style.fontStyle = FontStyle.Italic;
            style.normal.textColor = Color.grey;
            return style;
        }
    }
    
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {     
        position.height = attrib.height;
        EditorGUI.BeginProperty(position, label, property);  
        GUI.Box(position, attrib.comment, commentStyle);      
        position.y += attrib.height + 2;
        position.height = EditorGUIUtility.singleLineHeight;
        EditorGUI.PropertyField(position, property, label);
        EditorGUI.EndProperty();
    }
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        attrib = attribute as CommentAttribute;
        return (base.GetPropertyHeight(property, label)) + 1 + attrib.height;
    }
}