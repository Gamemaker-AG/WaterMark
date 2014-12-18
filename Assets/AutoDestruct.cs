using UnityEngine;
using System.Collections;

public class AutoDestruct : MonoBehaviour
{

	public float time = 10;
	// Use this for initialization
	void Start ()
	{
		Destroy (gameObject, time);
	}
}
