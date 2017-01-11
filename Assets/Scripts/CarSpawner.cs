using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

	public GameObject carPrefab;
	public Vector3 carPrefabSpawnLocation;
	public float nextspawn = 0f;


	// Use this for initialization
	void Start () {
		carPrefab = (GameObject) Resources.Load ("Prefabs/Car1", typeof(GameObject));	
	}
	
	// Update is called once per frame
	void Update () {
		Spawner ();
	}

	void Spawner()
	{
		float spawnrate = 1;
		float random = Random.Range (-2.5f, 2.5f);

		if (Time.time > nextspawn) {
			nextspawn = Time.time + spawnrate;
			carPrefabSpawnLocation = new Vector3 (random, 1, 70);
			Instantiate (carPrefab, carPrefabSpawnLocation, Quaternion.identity);
		}
	}
}
