using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomizerData))]
public class RandomizerDataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        RandomizerData data = (RandomizerData)target;

        EditorGUILayout.LabelField(data.Name.ToUpper(),
            EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        // add before
        base.OnInspectorGUI();
        // add after

        if(data.Name == string.Empty)
        {
            EditorGUILayout.HelpBox("Warning: Name missing",
                MessageType.Warning);
        }
        if(data.Amount < 0)
        {
            EditorGUILayout.HelpBox("Warning: Can't have negative amount",
                MessageType.Warning);
        }
        if (data.Range < 0)
        {
            EditorGUILayout.HelpBox("Warning: Can't have negative range",
                MessageType.Warning);
        }
        if (data.Scale < 0)
        {
            EditorGUILayout.HelpBox("Warning: Can't have negative scale",
                MessageType.Warning);
        }
    }
}
