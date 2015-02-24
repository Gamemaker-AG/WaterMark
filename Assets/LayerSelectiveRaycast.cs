using UnityEngine;
using System.Collections;

public class LayerSelectiveRaycast: MonoBehaviour
{

    //public Variables
    public Vector3 raycastOffset;
    public Vector3 rayDirection;
    public float rayDistance;
    public LayerMask layerMask;
    public RaycastHit hit;

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
        }

    }
}
