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
			rigidbody.AddForce(Vector3.forward * vor, ForceMode.Force);
			if(Input.GetKey(KeyCode.LeftArrow))
				rigidbody.AddTorque(Vector3.up * -rota, ForceMode.Force);
			if(Input.GetKey(KeyCode.RightArrow))
				rigidbody.AddTorque (Vector3.up * rota, ForceMode.Force);}

		if(Input.GetKey(KeyCode.DownArrow)){
			rigidbody.AddForce(-Vector3.forward * (vor/2), ForceMode.Force);
		if(Input.GetKey(KeyCode.LeftArrow))
				rigidbody.AddTorque(Vector3.up * -rota, ForceMode.Force);
		if(Input.GetKey(KeyCode.RightArrow))
				rigidbody.AddTorque (Vector3.up * rota, ForceMode.Force);}
}

}