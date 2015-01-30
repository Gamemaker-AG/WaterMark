using UnityEngine;
using System.Collections;

public class Floater : MonoBehaviour {
	public float waterLevel, floatHeight;
	public Vector3 buoyancyCentreOffset;
	public float bounceDamp;
   // public Ray rayDown; // = new Ray(transform.position, Vector3.down);


	void FixedUpdate () {
        //waterLevel calculation
        //waterLevel = new RaycastHit().point.y; //needs some research on usage of Raycasts

		Vector3 actionPoint = transform.position + transform.TransformDirection(buoyancyCentreOffset);
		float forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);
		
		if (forceFactor > 0f) {
			Vector3 uplift = -Physics.gravity * (forceFactor - rigidbody.velocity.y * (1 / bounceDamp));
			rigidbody.AddForceAtPosition(uplift, actionPoint);
		}
	}
}
