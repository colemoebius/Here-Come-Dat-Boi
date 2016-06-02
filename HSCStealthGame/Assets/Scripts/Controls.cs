using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {


	public float speed = 1f;
	public float jumpSpeed = 240f;
	public float forwardSpeed = 20;
	private Rigidbody2D body2d;
	private Animator animator;
	private AudioSource source;
	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;
	public AudioClip punch; 
	public float vol  = 0.25f;
	public bool canMove;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		source = GetComponent<AudioSource> ();
	}
	void Start () {		
		animator = GetComponent<Animator>();
		canMove = true;
	}


	void Example() {
			transform.rotation = Quaternion.identity;
	}



	void Update() {

		if (canMove = true) {
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
				animator.SetBool ("Running", true);
				animator.SetBool("Idle",false);


			
			}
		
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
				animator.SetBool ("Running", true);
				animator.SetBool("Idle",false);
		



			}
		
			if (Input.GetKey (KeyCode.DownArrow)) {
				GetComponent<Rigidbody2D> ().AddForce (-Vector2.up * speed);
			}
		
			if (Input.GetKey (KeyCode.UpArrow)) {

				animator.SetBool ("Running", true);
				animator.SetBool("Idle",false);

			}

			if (Input.anyKey == false&&animator.GetBool("Dead")!= true) {

				animator.SetBool ("Running", false);
				animator.SetBool("Idle",true);
			}

			

		}	
					float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
					float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
					Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
					transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
				}
			}
		
	




	// Use this for initialization

	// Update is called once per frame

