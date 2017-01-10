using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Transform CaseyTarget; // end maker
	public float speed;
	public Target target;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		Steering ();
	}

	void Steering () {

		CaseyTarget.transform.Translate(Input.acceleration.x, 0, 0);

		float time = Time.deltaTime * 10;

		transform.position = Vector3.Lerp(transform.position, CaseyTarget.position, time);
	}
}
