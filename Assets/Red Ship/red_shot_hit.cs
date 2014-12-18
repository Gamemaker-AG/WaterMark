using UnityEngine;
using System.Collections;

public class red_shot_hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) 
	{
		if (col.gameObject.tag == "EnemyBlue")
		{
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
	
	}
}
