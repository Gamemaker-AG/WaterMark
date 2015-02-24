using UnityEngine;
using System.Collections;

public class ExampleHover: MonoBehaviour
{
    public float moveForce = 1.0F;
    public float rotateTorque = 1.0F;
    public float hoverHeight = 4.0F;
    public float hoverForce = 5.0F;
    public float hoverDamp = 0.5F;


    void Start()
    {
        rigidbody.drag = 0.5F;
        rigidbody.angularDrag = 0.5F;
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(Input.GetAxis("Vertical") * moveForce * transform.forward);
        rigidbody.AddTorque(Input.GetAxis("Horizontal") * rotateTorque * Vector3.up);
        RaycastHit hit;
        Ray downRay = new Ray(transform.position, -Vector3.up);
        if (Physics.Raycast(downRay, out hit))
        {
            float hoverError = hoverHeight - hit.distance;
            if (hoverError > 0)
            {
                float upwardSpeed = rigidbody.velocity.y;
                float lift = hoverError * hoverForce - upwardSpeed * hoverDamp;
                rigidbody.AddForce(lift * Vector3.up);
            }
        }
    }
}