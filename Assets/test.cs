using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject prefab;

    // Click the "Instantiate!" button and a new `prefab` will be instantiated
    // somewhere within -10.0 and 10.0 (inclusive) on the x-z plane
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Instantiate!"))
        {
            var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
