using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Target : MonoBehaviour {

	public GameObject Casey;
	public float CaseysHeight;
	public float minSpeed;
	public Slider SpeedSlider;

	void Start () {
	
		Casey = GameObject.FindGameObjectWithTag ("Player");
		CaseysHeight = Casey.transform.position.y;
	}

	void Update () {

//		transform.Translate((Vector3.forward * 1) * Time.deltaTime * minSpeed * SpeedSlider.value);

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), CaseysHeight, transform.position.z);

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
