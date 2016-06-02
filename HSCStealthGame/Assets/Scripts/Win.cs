using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Win : MonoBehaviour {
	public GUIText text;
	// Use this for initialization
	void Start () {
		text = GetComponent<GUIText> ();
		GUI.Label(new Rect(300,300,500,200), "Hello World!");
		text.enabled = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag=="Player"){
			text.enabled = true;
			Debug.Log("enter");
		}
}
}