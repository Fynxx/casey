using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FullScreenSlider : MonoBehaviour {

	public float speed;
	public Transform slider;

	void Start(){
		speed = 0.2f;
	}

	void Update() {
		SpeedSlider ();
		Slider ();
		print (speed);
	}

	float SpeedSlider(){

		Ray ray;
		speed = (Input.GetTouch (0).position.y / 600);

		switch (Input.GetTouch(0).phase)
		{
//		case TouchPhase.Began:
//			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
//			if (Physics.Raycast (ray)) {
//				return speed;
//			} else {
//				return 0f;
//			}
//			break;
//		case TouchPhase.Stationary:
//			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
//			if (Physics.Raycast (ray)) {
//				return speed;
//			} else {
//				return 0f;
//			}
//			break;
		case TouchPhase.Moved:
			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			if (Physics.Raycast (ray)) {
				return speed;
			} else {
				return 0f;
			}
			break;
		case TouchPhase.Ended:
			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			if (Physics.Raycast (ray)) {
				return speed;
			} else {
				return 0f;
			}
			break;
//		case TouchPhase.Canceled:
//			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
//			if (Physics.Raycast (ray)) {
//				return speed;
//			} else {
//				return 0f;
//			}
//			break;
		default:
			print ("Fullscreenslider switchstatement is default.");
				return 0.2f;
			break;
		}
	}

	void Slider(){
		slider.transform.position = Input.GetTouch (0).position;
	}
}