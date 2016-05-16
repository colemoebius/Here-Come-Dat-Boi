using UnityEngine;
using System.Collections;
public class SeaUrchin : MonoBehaviour {
	protected Vector3 velocity;
	public Transform _transform;
	public float distance = 5f;
	public float speed = 1f;
	Vector3 _originalPosition;
	bool isGoingLeft = false;
	public float distFromStart;
	Vector3 theScale;
	public void Start () {
		_originalPosition = gameObject.transform.position;
		_transform = GetComponent<Transform>();
		theScale= transform.localScale;
		velocity = new Vector3(speed,0,0);
		_transform.Translate ( velocity.x*Time.deltaTime,0,0);
		theScale.x *= -1;

	}
	
	void Update()
	{    
		distFromStart = transform.position.x - _originalPosition.x;   
		
		if (isGoingLeft)
		{ 
			// If gone too far, switch direction
			if (distFromStart < -distance)
				SwitchDirection();
				
			_transform.Translate (-velocity.x * Time.deltaTime, 0, 0);
		}
		else
		{
			// If gone too far, switch direction
			if (distFromStart > distance)
				SwitchDirection();
			
			_transform.Translate (velocity.x * Time.deltaTime, 0, 0);

		}
	}
	
	void SwitchDirection()
	{
		isGoingLeft = !isGoingLeft;

		theScale.x *= -1;
		
		transform.localScale = theScale;
		//TODO: Change facing direction, animation, etc
	}
}