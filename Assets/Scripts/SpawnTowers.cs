using UnityEngine;
using System.Collections;

public class SpawnTowers : MonoBehaviour {
	
	public GameObject tower;
	public int spawnTimeOffset = 30;
	public Vector2 choice1 = new Vector2(10.0f, 0.0f);
	public Vector2 choice2 = new Vector2(-10.0f, 0.0f);
	private int actualSpawnTime = 0;
	private int choiceLoop = 0;

	void Start(){
		spawnTimeOffset *= 2;
		choice1.x = transform.position.x - choice1.x;
		choice1.y = transform.position.y - choice1.y;
		choice2.x = transform.position.x - choice2.x;
		choice2.y = transform.position.y - choice2.y;
	}

	// Update is called once per frame
	void Update () {
		if (actualSpawnTime == 0 && choiceLoop == 0) {
			Instantiate (tower, new Vector3 (choice1.x, choice1.y, 50.0f), Quaternion.identity);
			actualSpawnTime = spawnTimeOffset;
			choiceLoop = 1;
		} else if (actualSpawnTime == 0 && choiceLoop == 1) {
			Instantiate (tower, new Vector3 (choice2.x, choice2.y, 50.0f), Quaternion.identity);
			actualSpawnTime = spawnTimeOffset;
			choiceLoop = 0;
		} else {
			actualSpawnTime--;
		}
	}
}
