using UnityEngine;
using System.Collections;

public class EasyFollow : MonoBehaviour {

	public string ship = null;
	private float heightboat = 0f;
	private float heightcam = 0f;
	private float differ = 0f;

	// Use this for initialization
	void Start () {
		heightboat = GameObject.Find (ship).transform.position.y;
		heightcam = this.transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {
		differ = heightboat - GameObject.Find (ship).transform.position.y;
		heightboat = GameObject.Find (ship).transform.position.y;

		transform.position = new Vector3(transform.position.x,heightcam + differ, transform.position.z);
	
	}
}
