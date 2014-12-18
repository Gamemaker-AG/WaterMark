using UnityEngine;
using System.Collections;

public class shoot_red : MonoBehaviour {
	public Rigidbody Rcannonball;
	public Transform endOfWeaponRed;
	private float reloadTime;
	
	
	// Use this for initialization	
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () 
		
	{
		if(Input.GetButtonDown ("Fire1") && reloadTime <= Time.time)
		{
			Rigidbody Rcannonballclone;
			Rcannonballclone = Instantiate(Rcannonball, endOfWeaponRed.position, endOfWeaponRed.rotation)as Rigidbody;
			Rcannonballclone.AddForce(endOfWeaponRed.forward *15000* Time.deltaTime);
			reloadTime = Time.time + 3.0f;
		}
		
	}
}