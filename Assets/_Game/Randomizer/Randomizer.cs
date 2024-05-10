using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    [SerializeField]
    private RandomizerData _data;

    public RandomizerData Data => _data;

    public GameObject prefab;

    private void Awake()
    {
        Debug.Log("Name: " + _data.Name);
        Debug.Log("Range: " + _data.Range);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(-_data.Range*2, transform.position.y, _data.Range*2));
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Randomize"))
        {
            var position = new Vector3(Random.Range(-_data.Range, _data.Range),
                    transform.position.y, Random.Range(-_data.Range, _data.Range));
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
