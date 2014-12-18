using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	public int life;

	void Start () {
		life = 100;
	}
	
	// Update is called once per frame
	void Update () {
	 if(life <= 0)
		{
			Destroy(gameObject);
		}
	}

}
