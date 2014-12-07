using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	public int life;
	public int GUIPosition;

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

	void OnGUI(){
		GUI.TextField(new Rect(Screen.width/5 + GUIPosition, Screen.height -20, 120, 80), life.ToString());
		
	}
}
