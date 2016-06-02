using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public float delay = 2.0f;
	public bool active = false;
	public Vector2 delayRange = new Vector2(1, 2);
	private AudioSource source;
	public AudioClip zombie; 
	public float vol  = 0.25f;

	void Awake(){

		source = GetComponent<AudioSource> ();

	}
	// Use this for initialization
	void Start () {
		ResetDelay ();
		StartCoroutine (EnemyGenerator ());

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {

			active = true;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			active = false;
		}
	}
	IEnumerator EnemyGenerator(){

		yield return new WaitForSeconds (delay);

		if (active) {
			var newTransform = transform;
			source.PlayOneShot(zombie,vol); 

			GameObjectUtil.Instantiate(prefabs[Random.Range(1, prefabs.Length)], newTransform.position);
			ResetDelay();
			source.PlayOneShot(zombie,vol); 
		}

		StartCoroutine (EnemyGenerator ());

	}

	void ResetDelay(){
		delay = Random.Range (delayRange.x, delayRange.y);
	}

}
