using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMoveTarget : MonoBehaviour
{
    [SerializeField]
    private Vector3[] locations;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = locations[Random.Range(0, locations.Length)];
        }
    }
}
