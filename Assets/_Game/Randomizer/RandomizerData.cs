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
    [Tooltip("Amount of items that will generate")]
    private int _amount = 0;
    [SerializeField]
    [Tooltip("Range size where the items will generate")]
    private int _range = 1;
    [SerializeField]
    [Range(0, 360)]
    private int _rotate = 0;

    public string Name => _name;
    public int Amount => _amount;
    public int Range => _range;
    public int Rotate => _rotate;
}
