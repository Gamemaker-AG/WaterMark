using UnityEngine;
using System.Collections;

public class Floater : MonoBehaviour
{
    //Water Lvl Detection
    public Vector3 raycastOffset;
    public Vector3 rayDirection;
    public float rayDistance;
    public LayerMask layerMask;
    private RaycastHit hit;

    //Buoyancy stuff
    public float waterLevel, floatHeight, bounceDamp;
    public Vector3 buoyancyCentreOffset;
    //public Vector3[] ForcePoints; // to be continued ...

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("I'm alive!");

        Ray ray = new Ray(transform.position + raycastOffset, rayDirection);
        if (Physics.Raycast(ray, out hit, rayDistance, layerMask))
        {
            //Debug.Log("hit.distance: " + hit.distance);
            //Debug.Log("hit.point: " + hit.point);
            Debug.DrawLine(ray.origin, hit.point);
            waterLevel = hit.point.y;
        }

    }


    void FixedUpdate()
    {
        Vector3 actionPoint = transform.position + transform.TransformDirection(buoyancyCentreOffset);
        float forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);

        if (forceFactor > 0f)
        {
            Vector3 uplift = -Physics.gravity * (forceFactor - rigidbody.velocity.y * bounceDamp);
            rigidbody.AddForceAtPosition(uplift, actionPoint);
        }
    }
}
