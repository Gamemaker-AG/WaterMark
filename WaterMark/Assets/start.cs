using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

		
		public GUISkin theSkin;
		
		
		
		void OnGUI(){
			GUI.skin = theSkin;
			//GUI.Label ( new Rect(100 ,Screen.height/2 +150,500,100), "Highscore: " + PlayerPrefs.GetInt("highscore"));
			if(GUI.Button(new Rect(Screen.width/2 - 250/2, Screen.height/2 +50, 120, 80),"Play"))
			{
				Application.LoadLevel("franzitry");
				
			}
			
		}
	}