using UnityEngine;
using System.Collections;

public class FlipperControls : MonoBehaviour {
	private Animator animator;
	private Rigidbody2D myRigidbody;
	private float movementSpeed;
	private bool facingRight;
	private bool attacking;

	// Use this for initialization
	void Start () {
		facingRight = true;
		myRigidbody = GetComponent<Rigidbody2D> ();

	}


	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		HandleMovement (horizontal);
		//HandleAttacks();
		Flip (horizontal);
	}
	void Update(){
		//HandleInput ();
	}

	private void HandleMovement(float horizontal){

		myRigidbody.velocity = new Vector2(horizontal * movementSpeed,myRigidbody.velocity.y);

	}
	private void HandleAttacks(){
		if (attacking) {
			animator.SetTrigger("Punching");
		}
	}
	private void HandleInput(){
		if (Input.GetKey (KeyCode.Z)) {
			attacking=true;
		}
	}
	private void Flip(float horizontal){
		if (horizontal > 0 && !facingRight || horizontal<0 && facingRight) {
			facingRight = !facingRight;

			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}
}
