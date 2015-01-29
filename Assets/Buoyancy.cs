using UnityEngine;
using System.Collections;

public class Buoyancy : MonoBehaviour {
	public float vertForce = 12.72f;  // 9.81 is the opposite of the default gravity, which is -9.81
        //If we want the boat not to behave like a submarine the upward force has to be higher than the gravity in order to push the boat to the surface
        //to prevent continuous bobbing the vertical force needs to be calculated by the depth the object is dipping the water
	private bool isInWater = false;
	
	void OnTriggerEnter(Collider collidier) {
		isInWater = true;
		//rigidbody.drag = 5f;
	}
	
	void OnTriggerExit(Collider collidier) {
		isInWater = false;
		//rigidbody.drag = inAirDrag;
	}
	
	void FixedUpdate() {
		if(isInWater) {
			// apply upward force
			Vector3 force = transform.up * vertForce;
			this.rigidbody.AddRelativeForce(force, ForceMode.Acceleration);
			//Debug.Log("vertical force: " + force+" @"+Time.time);
		}
	}
}
