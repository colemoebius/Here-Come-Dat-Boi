using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	public string scene;
	// Use this for initialization
	void Start () {

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel (scene);
		}
	}
	
}
