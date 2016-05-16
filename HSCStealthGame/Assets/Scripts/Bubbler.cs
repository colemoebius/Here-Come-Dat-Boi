using UnityEngine;
using System.Collections;

public class Bubbler : MonoBehaviour {
	public bool Bubbling;	// Reference to the animator bool to trigger the state.

	private Animator anim;		// Reference to the animator component.
	private GameObject player;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter2D (Collider2D other){
		anim.SetBool("Bubbling", true);
			}

	void OnTriggerExit2D (Collider2D other){
		anim.SetBool("Bubbling", false);
	}
}
