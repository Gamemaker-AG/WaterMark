using UnityEngine;
using System.Collections;

public class move_improv : MonoBehaviour {

	public float vor = 1f;
	public float zur = 1f;
	public float rota = 1f;


	// Use this for initialization
	void Start () {
	
	}
	

	void Update () 
	{
		// Movement mit Trägheit, momentan bewegt sich der Rigidbody aber auf einer Achse
		// unabhängig von der Ausrichtung :/
		if(Input.GetKey(KeyCode.UpArrow)){
			rigidbody.AddForce(transform.forward * vor * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(KeyCode.LeftArrow))
				rigidbody.AddTorque(transform.up * -rota * Time.deltaTime, ForceMode.Force);
			if(Input.GetKey(KeyCode.RightArrow))
				rigidbody.AddTorque (transform.up * rota * Time.deltaTime, ForceMode.Force);}

		if(Input.GetKey(KeyCode.DownArrow)){
			rigidbody.AddForce(-transform.forward * (vor/2) * Time.deltaTime, ForceMode.Force);
		if(Input.GetKey(KeyCode.LeftArrow))
				rigidbody.AddTorque(transform.up * rota * Time.deltaTime, ForceMode.Force);
		if(Input.GetKey(KeyCode.RightArrow))
				rigidbody.AddTorque (transform.up * -rota * Time.deltaTime, ForceMode.Force);}

		if(Input.GetKey(KeyCode.LeftArrow))
			rigidbody.AddTorque(transform.up * (-rota/2) * Time.deltaTime, ForceMode.Force);
		if(Input.GetKey (KeyCode.RightArrow))
			rigidbody.AddTorque (transform.up * (rota/2) * Time.deltaTime, ForceMode.Force);
}

}