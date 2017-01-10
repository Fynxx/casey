using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ForwardMovement : MonoBehaviour {

	public Target target;
	public float minSpeed;
//	public Slider SpeedSlider;
	public FullScreenSlider SpeedSlider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate((Vector3.forward * 1) * Time.deltaTime * minSpeed * (SpeedSlider.speed));

	
	}
}
