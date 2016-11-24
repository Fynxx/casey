using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast (transform.position, fwd, 1)) {
			print ("There is something in front of the object!");
		}
	}
}
