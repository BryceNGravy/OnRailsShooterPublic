using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyOnContact : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private Vector3 spawnPosition;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
    }
}
