using UnityEngine;
using System.Collections;

public class DestoryOnInvisible : MonoBehaviour {

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
