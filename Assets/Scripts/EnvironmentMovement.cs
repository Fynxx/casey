using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnvironmentMovement : MasterMovement {

	public Rigidbody rb;

	public GameObject prefab1;
	public GameObject prefab2;

	public Vector3 prefabSpawnLocation;

	public GameObject placedPrefab;
	public float SpeedMultiplier;
	public bool isCar;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		SpeedSlider = GameObject.Find ("SpeedSlider").GetComponent<Slider> ();
		SpeedMultiplier = 20;
		prefab1 = (GameObject) Resources.Load ("Prefabs/CityBlock", typeof(GameObject));
		prefab2 = (GameObject) Resources.Load ("Prefabs/CityBlock2", typeof(GameObject));
		prefabSpawnLocation = new Vector3 (0, 0, 70);
		isCar = false;
	}

	void Update () 
	{
		Movement (SpeedMultiplier, isCar); 
		BlockSpawner ();
	}

//	void CBMovement()
//	{
//		speed = SpeedSlider.value * SpeedMultiplier;
//		transform.Translate((Vector3.forward * -1) * Time.deltaTime * speed);
//	}

	void BlockSpawner()
	{
		float randomNumber;
		if (transform.position.z <= -20)
		{
			Destroy(gameObject);
			randomNumber = Random.Range (0f, 1f);
			if (randomNumber < .5f) {
				placedPrefab = prefab1;
			} else {
				placedPrefab = prefab2;
			}

			Instantiate (placedPrefab, prefabSpawnLocation, Quaternion.identity);
		}
	}
}
