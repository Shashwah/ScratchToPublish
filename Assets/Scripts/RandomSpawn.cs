using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour {

	public GameObject spawnObject;
	public float minHorizontal = -10.0f;
	public float maxHorizontal = 10.0f;

	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 1.0f;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnNow", Random.Range (minSpawnTime, maxSpawnTime));
	}
	
	void SpawnNow(){
		Instantiate (spawnObject, transform.position + new Vector3(Random.Range (minHorizontal, maxHorizontal), 0.0f, 0.0f), Quaternion.identity);
		Invoke("SpawnNow", Random.Range (minSpawnTime, maxSpawnTime));
	}
}
