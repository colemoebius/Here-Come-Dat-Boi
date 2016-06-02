using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	private Rigidbody2D body2d;

	public int jumpcount = 0;
	public bool grounded;
	public bool candoublejump;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)&&jumpcount<2){
			body2d.velocity = new Vector2 (body2d.velocity.x, 75);
			jumpcount++;
			Debug.Log (jumpcount);
		}


	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Ground") {
			jumpcount=0;
		}
	}


}
