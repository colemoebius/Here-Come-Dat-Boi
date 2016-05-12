using UnityEngine;
using System.Collections;

public class Bubbles : MonoBehaviour {
	
	public float routeLenght = 10;
	public float verticalSpeed = 10;
	[Range (0,1)]
	public float startRelativePosition=0;
	
	public bool goUp;
	Vector3 basePosition, remotePosition;
	void Start(){
		basePosition = transform.position;
		remotePosition = getRemotePosition();
		transform.position = Vector3.Lerp(basePosition, remotePosition, startRelativePosition);
		updateVelocity();
	}
	
	Vector2 velocity;
	void Update(){

			goUp = true;
			updateVelocity();

		GetComponent<Rigidbody2D>().velocity = velocity;
	}
	
	void updateVelocity(){
		velocity = new Vector2(0, goUp ?  verticalSpeed : -verticalSpeed);
	}
	
	Vector3 getRemotePosition(){
		return basePosition + new Vector3(0, routeLenght, 0);
	}
	
	void OnDrawGizmos(){
		if (Application.isPlaying){
			Gizmos.DrawLine(basePosition, remotePosition);
		} else {			
			Vector2 boxSize = (GetComponent<Collider2D>() as BoxCollider2D).size; 
			basePosition = transform.position;
			remotePosition = getRemotePosition();
			Gizmos.DrawLine(transform.position, remotePosition);
			Gizmos.DrawCube(Vector3.Lerp(basePosition, remotePosition, startRelativePosition),boxSize);
		}
		
	}

}