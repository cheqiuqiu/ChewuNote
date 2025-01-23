<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class 序列化 : MonoBehaviour
{
    [SerializeField]
    private int Id;
    [SerializeField]
    private GameObject[] Targets;
#if UNITY_EDITOR
    [CustomEditor(typeof(ScriptableObject))]
    public class ScriptInsector : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            SerializedProperty property = serializedObject.FindProperty(nameof(Id));
            property.intValue = EditorGUILayout.IntField("主键",property.intValue);
            EditorGUILayout.PropertyField(serializedObject.FindProperty(nameof(targets)),true);
            serializedObject.ApplyModifiedProperties();
        }
    }




#endif





}
=======
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class 序列化 : MonoBehaviour
{
    [SerializeField]
    private int Id;
    [SerializeField]
    private GameObject[] Targets;
#if UNITY_EDITOR
    [CustomEditor(typeof(ScriptableObject))]
    public class ScriptInsector : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            SerializedProperty property = serializedObject.FindProperty(nameof(Id));
            property.intValue = EditorGUILayout.IntField("主键",property.intValue);
            EditorGUILayout.PropertyField(serializedObject.FindProperty(nameof(targets)),true);
            serializedObject.ApplyModifiedProperties();
        }
    }




#endif





}
>>>>>>> 5b5d006049d1f6a35a9c791f8900d71c72d73da2
