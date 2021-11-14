 using UnityEngine;
 
 public class AdditionalTextAttribute : PropertyAttribute
 {
 
     public readonly string Text;
     public AdditionalTextAttribute(string text)
     {
         Text = text + " ";
     }
 }