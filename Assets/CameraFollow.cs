using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private float camx = 0f;
	private float camy = 0f;
	private float camz = 0f;

	public float rotationx = 0f;
	public float rotationy = 0f;
	public float rotationz = 0f;
	

	// Use this for initialization
	void Start () {
		var pos = transform.position;
		camx = pos.x;
		camy = pos.y;
		camz = pos.z;

		//transform.position = new Vector3(camx, camy, camz);
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(camx + (GameObject.Find ("RED").transform.position.x), camy, camz + (GameObject.Find ("RED").transform.position.z));
		//transform.rotation.x = rotationx;


	
	}
}
