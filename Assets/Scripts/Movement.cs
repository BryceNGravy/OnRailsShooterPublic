using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private GameObject plane;
    private Rigidbody planeBody;
    [SerializeField]
    private float movementSpeed = 1.0f;
    [SerializeField]
    private float rotationSpeed = 1.0f;

    private float hAxis;
    private float vAxis;

    private void Start()
    {
        planeBody = plane.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");
        MovePlane();
        RotatePlane();
    }

    private void MovePlane()
    {
        Vector3 movementVector = Vector3.zero;

        if(hAxis != 0)
        {
            movementVector += transform.right * movementSpeed * hAxis;
        }
        if(vAxis != 0)
        {
            movementVector += transform.up * movementSpeed * vAxis;
        }

        planeBody.velocity = movementVector;
    }

    private void RotatePlane()
    {
        //issue: rotation becomes offset very quickly and doesn't blend as intended
        //issue: rotation isn't clamped
        //rotation will likely need to reset after player finishes moving
        if(hAxis != 0)
        {
            plane.transform.RotateAround(-plane.transform.up + plane.transform.forward, -hAxis * Time.fixedDeltaTime * rotationSpeed);
        }
        if (vAxis != 0)
        {
            plane.transform.RotateAround(transform.right, -vAxis * Time.fixedDeltaTime * rotationSpeed);
        }
    }

    private void Fire()
    {
        //fire two projectiles from the plane
    }
}
