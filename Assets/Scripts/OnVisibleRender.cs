using UnityEngine;
using System.Collections;

public class OnVisibleRender : MonoBehaviour {

	void OnBecameInvisible(){
		this.renderer.enabled = false;
	}

	void OnBecameVisible(){
		this.renderer.enabled = true;
	}
}
