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

    private void OnEnable()
    {
        _name = serializedObject.FindProperty("_name");
        _amount = serializedObject.FindProperty("_amount");
        _range = serializedObject.FindProperty("_range");
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
    }
}
