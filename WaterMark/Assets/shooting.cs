using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {

	public Rigidbody projectile;
	public float speed = 20;
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Rigidbody instantiatedProjectile = Instantiate(projectile
			                                               ,new Vector3(transform.position.x +0.5f,transform.position.y +0.4f , transform.position.z)
			                                               ,transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0, 0));

		}
		if (Input.GetMouseButtonDown(1))
		{
			Rigidbody instantiatedProjectile = Instantiate(projectile,new Vector3(transform.position.x -0.5f,transform.position.y +0.4f , transform.position.z),transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(-speed, 0, 0));

		}

	}
}
