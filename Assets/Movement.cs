using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{

	public float acc = 1f;
	public float torque = 1f;
	public KeyCode Up;
	public KeyCode Down;
	public KeyCode Left;
	public KeyCode Right;


	// Use this for initialization
	void Start () {
	
	}
	

	void Update () 
	{
		// Movement mit Trägheit
		if(Input.GetKey(Up))
		{
			rigidbody.AddForce(transform.forward * acc * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(Left))
				rigidbody.AddTorque(transform.up * -torque * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(Right))
				rigidbody.AddTorque (transform.up * torque * Time.deltaTime, ForceMode.Force);
		}

		if(Input.GetKey(Down))
		{
			rigidbody.AddForce(-transform.forward * (acc/2) * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(Left))
				rigidbody.AddTorque(transform.up * torque * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(Right))
				rigidbody.AddTorque (transform.up * -torque * Time.deltaTime, ForceMode.Force);
		}

		if(Input.GetKey(Left))
			rigidbody.AddTorque(transform.up * (-torque/2) * Time.deltaTime, ForceMode.Force);
		if(Input.GetKey (Right))
			rigidbody.AddTorque (transform.up * (torque/2) * Time.deltaTime, ForceMode.Force);
	}

}