using UnityEngine;
using System.Collections;

public class DestroyOnPosition : MonoBehaviour {

	public Vector3 deathPosition = new Vector3(0.0f, 0.0f, 0.0f);
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z <= deathPosition.z) {
			Destroy(gameObject);
		}
	}
}
