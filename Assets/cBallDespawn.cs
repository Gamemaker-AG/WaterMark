using UnityEngine;
using System.Collections;

public class cBallDespawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
