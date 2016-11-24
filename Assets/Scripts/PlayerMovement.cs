using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Transform CaseyTarget; // end maker

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement () {
//		rb.AddForce (transform.right * (SteeringInput));

		CaseyTarget.transform.Translate(Input.acceleration.x, 0, 0);

		float time = Time.deltaTime * 10;

		transform.position = Vector3.Lerp(transform.position, CaseyTarget.position, time);
	}
}
