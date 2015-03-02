using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class passiveFloater : MonoBehaviour
{
    //public List<GameObject> _items; 
    public Dictionary<GameObject, Vector3> _items;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //layermask = test.value;
    }

    //called with FixedUpdate timer for every Collider other that is touching the trigger.
    void OnTriggerStay(Collider other)
    {
        if (other.rigidbody != null)
        {
            float test = (other.transform.position - transform.position).magnitude;
            float factor;
            if (test > -other.bounds.extents.magnitude)
            {
                factor = 0.5f; // TODO - how far the bounds of other intersect the water?
            }
            else
            {   //if the object is completly inside the water
                factor = 1;
            }
            _items[other.gameObject] = -Physics.gravity * other.rigidbody.mass * factor; // TODO - 
            //instead of the mass of other the mass of the water in space of the bound of other.
        }
    }

    void OnTriggerEnter(Collider other)
    {
        _items.Add(other.gameObject, Vector3.zero);
    }
    void OnTriggerExit(Collider other)
    {
        _items.Remove(other.gameObject);
    }

}
