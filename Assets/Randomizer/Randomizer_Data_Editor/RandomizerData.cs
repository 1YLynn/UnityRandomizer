using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "RandomizerData_", menuName = "UnitData/Randomizer")]
public class RandomizerData : ScriptableObject
{
    [Header("General")]
    [SerializeField]
    private string _name = "...";
    [SerializeField]
    [Tooltip("Range size where the items will generate")]
    private int _range = 1;

    public string Name => _name;
    public int Range => _range;
}
