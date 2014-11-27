using UnityEngine;
using System.Collections;

public class blue_move : MonoBehaviour {

	public float speedfow = 1f;
	public float turnSpeed =1f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.Translate (Vector3.forward* speedfow * Time.deltaTime);
			if(Input.GetKey(KeyCode.A))
				transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
			if(Input.GetKey(KeyCode.D))
				transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);}
		
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(-Vector3.forward * (speedfow/3 )* Time.deltaTime);
			if(Input.GetKey(KeyCode.A))
				transform.Rotate(Vector3.up, (turnSpeed/2) * Time.deltaTime);
			if(Input.GetKey(KeyCode.D))
				transform.Rotate(Vector3.up, (-turnSpeed/2) * Time.deltaTime);}
	}
}
