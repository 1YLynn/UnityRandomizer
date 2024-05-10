using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    [SerializeField]
    private RandomizerData _data;

    public RandomizerData Data => _data;

    private void Awake()
    {
        Debug.Log("Name: " + _data.Name);
        Debug.Log("Amount: " + _data.Amount);
        Debug.Log("Range: " + _data.Range);
        Debug.Log("Rotate: " + _data.Rotate);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _data.Range);
    }
}
