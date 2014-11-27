using UnityEngine;
using System.Collections;

public class shoot_blue : MonoBehaviour {
	public Rigidbody Bcannonball;
	public Transform endOfWeaponBlue;
	private float reloadTime;
	
	
	// Use this for initialization	
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () 
		
	{
		if(Input.GetButtonDown ("Fire2") && reloadTime <= Time.time)
		{
			Rigidbody Bcannonballclone;
			Bcannonballclone = Instantiate(Bcannonball, endOfWeaponBlue.position, endOfWeaponBlue.rotation)as Rigidbody;
			Bcannonballclone.AddForce(endOfWeaponBlue.forward *15000* Time.deltaTime);
			reloadTime = Time.time + 3.0f;
		}
		
	}
}