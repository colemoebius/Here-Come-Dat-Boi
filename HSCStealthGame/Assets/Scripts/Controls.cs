using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {


	public float speed = 1f;
	public float jumpSpeed = 240f;
	public float forwardSpeed = 20;
	private Rigidbody2D body2d;
	private Animator animator;
	private AudioSource source;
	public AudioClip punch; 
	public float vol  = 0.25f;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		source = GetComponent<AudioSource> ();
	}
	void Start () {		
		animator = GetComponent<Animator>();
	}


	void Update() {


		if(Input.GetKey(KeyCode.RightArrow)) {
			transform.position += new Vector3(speed*Time.deltaTime, 0.0f, 0.0f);
			animator.SetBool ("Running", true);
			animator.SetBool("Idle", false);
			animator.SetBool("Punching",false);
			
		}
		
		if(Input.GetKey(KeyCode.LeftArrow)) {
			transform.position -= new Vector3(speed*Time.deltaTime, 0.0f, 0.0f);
			animator.SetBool ("Running", true);
			animator.SetBool("Idle", false);
			animator.SetBool("Punching",false);



					}
		
		if(Input.GetKey(KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D>().AddForce(-Vector2.up * speed);
		}
		
		if(Input.GetKey(KeyCode.UpArrow)) {

			animator.SetBool ("Running", true);
			animator.SetBool("Idle", false);
			animator.SetBool("Punching",false);
		}
		if (Input.GetKey (KeyCode.Z)) {
			animator.SetBool("Punching",true);
			animator.SetBool("Idle", false);
			animator.SetBool ("Running", false);
			source.PlayOneShot(punch,vol); 
		}
		if (Input.anyKey == false) {
			animator.SetBool("Idle",true);
			animator.SetBool("Running", false);
			animator.SetBool("Punching",false);
		}
	}

}

	// Use this for initialization

	// Update is called once per frame

