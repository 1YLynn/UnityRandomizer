using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    [Header("General")]
    [SerializeField]
    private string _name;
    [SerializeField]
    private int _amount;
    [SerializeField]
    private int _range;
    [SerializeField][Range(0,360)]
    private int _rotate;
    [SerializeField]
    private int _scale;
}
