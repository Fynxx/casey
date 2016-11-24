using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MasterMovement : MonoBehaviour {

	public float thrust;
	public float speed;
	public Slider SpeedSlider;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float Movement(float multiplier, bool isCar)
	{
		if (isCar == true) {
			speed = multiplier; 
		} else {
			speed = SpeedSlider.value * multiplier;
		}

		transform.Translate((Vector3.forward * -1) * Time.deltaTime * speed);
		return speed;
	}
}
