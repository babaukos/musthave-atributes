using System;
using UnityEngine;
using System.Collections;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class CommentAttribute : PropertyAttribute
{
    /// <summary>
    ///   <para>The header text.</para>
    /// </summary>
    public readonly string comment;

    /// <summary>
    /// The height
    /// </summary>
    public readonly float height = 16f;

    // /// <summary>
    // /// The color
    // /// </summary>
    // public readonly Color color = Color.gray;

    /// <summary>
    /// Add a comment above some fields in the Inspector.
    /// </summary>
    /// <param name="comment">The header text.</param>
    public CommentAttribute(string comment)
    {
        this.comment = comment;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommentAttribute"/> class.
    /// </summary>
    /// <param name="comment">The comment.</param>
    /// <param name="height">The height.</param>
    public CommentAttribute(string comment, float height)
    {
        this.comment = comment;
        this.height = height;
    }
    // /// <summary>
    // /// Initializes a new instance of the <see cref="CommentAttribute"/> class.
    // /// </summary>
    // /// <param name="comment">The comment.</param>
    // /// <param name="color">The color of text.</param>
    // public CommentAttribute(string comment, Color color)
    // {
    //     this.comment = comment;
    //     this.color = color;
    // }
}
