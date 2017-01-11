using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FullScreenSlider : MonoBehaviour {

	public float speed;
	public float standardFov;
	public Transform slider;
	public Text testYValue;

	void Start(){
		speed = 0.2f;
		standardFov = 50;
	}

	void Update() {
		SpeedSlider ();
		Slider ();
		DollyZoom ();
//		print (speed);
	}

	float SpeedSlider(){

		Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
		speed = (Input.GetTouch (0).position.y / 600);

		switch (Input.GetTouch(0).phase)
		{
		case TouchPhase.Began:
			if (Physics.Raycast (ray)) {
				return speed;
			} else {
				return 0f;
			}
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
//			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			if (Physics.Raycast (ray)) {
				return speed;
			} else {
				return 0f;
			}
//			break;
		case TouchPhase.Ended:
//			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			if (Physics.Raycast (ray)) {
				return speed;
			} else {
				return 0f;
			}
//			break;
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
//			break;
		}
	}

	void Slider(){
		slider.transform.position = Input.GetTouch (0).position;
		testYValue.text = Input.GetTouch (0).position.y.ToString();
	}

	void DollyZoom(){
		

		GetComponent<Camera> ().fieldOfView = standardFov + (speed * 10);

//		Vector2 random = new Vector2(Random.Range(0, speed), Random.Range(0, speed));
//
//		Vector2 tempXY = new Vector2 (transform.position.x, transform.position.y); 
//
//		Vector2 shake = new Vector2 (transform.position.x * random.x, transform.position.y * random.y);
//
//		transform.position = shake;
//		print (tempXY);

	}
}