using UnityEngine;
using System.Collections;

public class LevelGeneration : MonoBehaviour {

	public Transform levelBlock;
	public Transform playerCam;
	public Vector3 spawnPos;
	public float playerPos;
	public float test; 

	private bool canPlace;

	// Use this for initialization
	void Start () {
		canPlace = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		Spawn ();

	}

	void Spawn(){

		playerPos = Mathf.Round (playerCam.position.z);
		spawnPos = new Vector3 (0, 0, test + 100);
		float rem = playerPos % 10;
		print (rem);
		if (playerPos >= test){
			test += 10;
			canPlace = true;
			if (canPlace == true) {
				Instantiate (levelBlock, spawnPos, Quaternion.identity);
				print ("building placed");
				canPlace = false;
			}
		}
	}
}
