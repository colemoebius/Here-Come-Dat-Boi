 using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public GameObject player;
	Vector3 spawnPoint;
	public Animator animator;
	void Start()
	{
		GameObject spawnObject = GameObject.FindGameObjectWithTag ("Respawn");
		spawnPoint = spawnObject.transform.position;
		animator = GetComponent<Animator> ();
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Enemy") {
			Debug.Log ("Hit");



				transform.position = spawnPoint;

		}
		}

	void Update(){
		if(transform.position.y < -100){
			transform.position = spawnPoint;
			Debug.Log("fall");
	}
}
}
