using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {

	public float speed = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, 0.0f, 0.0f) * Time.deltaTime;
	}	
}
