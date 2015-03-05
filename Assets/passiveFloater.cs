using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class passiveFloater : MonoBehaviour
{
    //public List<GameObject> _items; 
    //public Dictionary<Collider, Vector3> _items;
    public Dictionary<Collider, float> _originalDrag;
    public Dictionary<Collider, float> _volumeInformation;
    public List<GameObject> listOfTrackedObjects;

    void Start()
    {
        //_items = new Dictionary<Collider, Vector3>();
        _originalDrag = new Dictionary<Collider, float>();
        _volumeInformation = new Dictionary<Collider, float>();
        listOfTrackedObjects = new List<GameObject>();
    }

    //called with FixedUpdate timer for every Collider other that is touching the trigger.
    void OnTriggerStay(Collider other)
    {

        //if (other.rigidbody != null)
        //{
        Vector3 force = -Physics.gravity * _volumeInformation[other];

        float factor;
        float test = other.transform.position.y - transform.position.y;

        if (test > -other.bounds.extents.y)
        {
            factor = 1 /
                (other.bounds.size.y / (other.bounds.extents.y - test));
            if (factor == 0) { factor = Mathf.Epsilon; }

            force = (-Physics.gravity * _volumeInformation[other] * factor);
            other.rigidbody.AddForceAtPosition(force, GetActionPoint(other.transform));
        }
        else
        {   //if the object is completly inside the water
            other.rigidbody.AddForce(force, ForceMode.Force);
        }
        //}
    }

    private Vector3 GetActionPoint(Transform transform)
    {
        Bounds b = transform.GetComponent<MeshFilter>().mesh.bounds;

        throw new System.NotImplementedException(); //TODO
    }

    void OnTriggerEnter(Collider other)
    {
        //_items.Add(other, Vector3.zero);
        _originalDrag.Add(other, other.rigidbody.drag);
        other.rigidbody.drag *= 3;
        listOfTrackedObjects.Add(other.gameObject);

        //Volume
        float mass = other.rigidbody.mass;
        other.rigidbody.SetDensity(1);
        _volumeInformation.Add(other, other.rigidbody.mass); //the mass of an object with a density of 1 represents it's volume
        other.rigidbody.mass = mass;
        Debug.Log("Volume of " + other.gameObject + ": " + _volumeInformation[other]);
    }
    void OnTriggerExit(Collider other)
    {
        //_items.Remove(other);
        other.rigidbody.drag = _originalDrag[other];
        _originalDrag.Remove(other);
        _volumeInformation.Remove(other);
        listOfTrackedObjects.Remove(other.gameObject);
    }

}
