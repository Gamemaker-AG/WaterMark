using UnityEngine;
using System.Collections;

public class blue_move_improvement : MonoBehaviour {

	public float vor = 1f;
	public float zur = 1f;
	public float rota = 1f;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	
	void FixedUpdate () 
	{
		// Movement mit Trägheit
		if(Input.GetKey(KeyCode.W)){
			rigidbody.AddForce(transform.forward * vor * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(KeyCode.A))
				rigidbody.AddTorque(transform.up * -rota * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(KeyCode.D))
				rigidbody.AddTorque (transform.up * rota * Time.deltaTime, ForceMode.Force);}
		
		if(Input.GetKey(KeyCode.S)){
			rigidbody.AddForce(-transform.forward * (vor/2) * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(KeyCode.A))
				rigidbody.AddTorque(transform.up * rota * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(KeyCode.D))
				rigidbody.AddTorque (transform.up * -rota * Time.deltaTime, ForceMode.Force);}
		
		if(Input.GetKey(KeyCode.A))
			rigidbody.AddTorque(transform.up * (-rota/2) * Time.deltaTime, ForceMode.Force);
		if(Input.GetKey (KeyCode.D))
			rigidbody.AddTorque (transform.up * (rota/2) * Time.deltaTime, ForceMode.Force);
	}
	
}
