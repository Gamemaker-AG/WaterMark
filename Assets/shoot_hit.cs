using UnityEngine;
using System.Collections;

public class shoot_hit : MonoBehaviour {


	void OnTriggerEnter (Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			PlayerManager script = col.GetComponent<PlayerManager>();
			script.life -= 5;
			Destroy(gameObject);

		}
	}
}
