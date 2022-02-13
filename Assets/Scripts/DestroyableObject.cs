using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    [SerializeField]
    private GameObject parentObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Projectile")
        {
            if(parentObject != null)
            {
                Destroy(parentObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
