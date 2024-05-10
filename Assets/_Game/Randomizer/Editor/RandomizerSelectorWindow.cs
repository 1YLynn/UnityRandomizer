using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RandomizerSelectorWindow : EditorWindow
{
    [MenuItem("Window/Randomizer Selector")]
    public static void ShowWindow()
    {
        GetWindow<RandomizerSelectorWindow>("Randomizer Selector");
    }
    private void OnGUI()
    {
        // window code goes here
    }
}
