using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Content;

[CustomEditor(typeof(RandomizerData))]
public class RandomizerDataEditor : Editor
{
    private SerializedProperty _name;
    private SerializedProperty _amount;
    private SerializedProperty _range;
    private SerializedProperty _rotate;
    private SerializedProperty _scale;

    private void OnEnable()
    {
        _name = serializedObject.FindProperty("_name");
        _amount = serializedObject.FindProperty("_amount");
        _range = serializedObject.FindProperty("_range");
        _rotate = serializedObject.FindProperty("_rotate");
        _scale = serializedObject.FindProperty("_scale");
    }
    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField(_name.stringValue.ToUpper(),
            EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        // add before
        base.OnInspectorGUI();
        // add after

        if (_name.stringValue == string.Empty)
        {
            EditorGUILayout.HelpBox("Warning: Name missing",
                MessageType.Warning);
        }
        if(_amount.intValue < 0)
        {
            EditorGUILayout.HelpBox("Warning: Can't have negative amount",
                MessageType.Warning);
        }
        if (_range.intValue < 0)
        {
            EditorGUILayout.HelpBox("Warning: Can't have negative range",
                MessageType.Warning);
        }
        if (_scale.intValue < 0)
        {
            EditorGUILayout.HelpBox("Warning: Can't have negative scale",
                MessageType.Warning);
        }
    }
}
