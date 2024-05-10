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
        Debug.Log("Amount: " + _data.Amount);
        Debug.Log("Range: " + _data.Range);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(-_data.Range*2, transform.position.y, _data.Range*2));
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for (var i = 0; i < _data.Amount; i++)
            {
                /*
                GameObject obj = Instantiate(prefab);
                obj.transform.position = new Vector3(Random.Range(-_data.Range, _data.Range),
                    transform.position.y, Random.Range(-_data.Range, _data.Range));
                */
                
                var position = new Vector3(Random.Range(-_data.Range, _data.Range),
                    transform.position.y, Random.Range(-_data.Range, _data.Range));
                Instantiate(prefab, position, Quaternion.identity);
                
            }
        }
    }
}
