using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarMovement : MasterMovement {

	public float SpeedMultiplier;
	public bool isCar;

	// Use this for initialization
	void Start () {
		SpeedMultiplier = Random.Range (0f, 20f);
		SpeedSlider = GameObject.Find ("SpeedSlider").GetComponent<Slider> ();
		isCar = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		Movement (SpeedMultiplier, isCar);
	}

}
