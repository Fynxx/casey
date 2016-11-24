using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public GameObject Casey;
	public float CaseysHeight;

	void Start () {
	
		Casey = GameObject.FindGameObjectWithTag ("Player");
		CaseysHeight = Casey.transform.position.y;
	}

	void Update () {

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), CaseysHeight, 0);

//		float xPos = transform.position.x;
//		if (xPos <= -3) {
//			xPos = -3;
//			print ("ik ga te ver");
//		}
//
//		if (xPos >= 3) {
//			xPos = 3;
//			print ("ik ga te ver");
//		}
	
	}
}
