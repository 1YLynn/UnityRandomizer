using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RandomizerData_", menuName = "UnitData/Randomizer")]
public class RandomizerData : ScriptableObject
{
    [Header("General")]
    [SerializeField]
    private string _name = "...";
    [SerializeField]
    private int _amount = 0;
    [SerializeField]
    [Tooltip("Radius size where the items will generate")]
    private int _range = 1;
    [SerializeField]
    [Range(0, 360)]
    private int _rotate = 0;
    [SerializeField]
    private int _scale = 1;
}
