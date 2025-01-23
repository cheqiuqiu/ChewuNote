using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class 自定义属性面板 : MonoBehaviour
{
    [RangeInt(0, 100)]
    public int a;
}
public sealed class RangeIntAttribute : PropertyAttribute
{
    public readonly int min;
    public readonly int max;
    public RangeIntAttribute(int min, int max)
    {
        this.min = min;
        this.max = max;
    }
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(RangeIntAttribute))]
    public sealed class RangeIntDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 100;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            RangeIntAttribute attribute = this.attribute as RangeIntAttribute;
            property.intValue = Mathf.Clamp(property.intValue,attribute.min,attribute.max);
            EditorGUI.HelpBox(new Rect(position.x, position.y, position.width, 30),string.Format("范围{0}-{1}",attribute.min,attribute.max),MessageType.Info);
            EditorGUI.PropertyField(new Rect(position.x, position.y + 35, position.width, 20),property,label);
        }
    }

#endif
}