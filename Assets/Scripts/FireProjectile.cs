using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private float force;
    [SerializeField]
    private float lifetime;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation);
        newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * force);
        newProjectile.transform.Rotate(new Vector3(90, 0, 0));
        Destroy(newProjectile, lifetime);
    }
}
