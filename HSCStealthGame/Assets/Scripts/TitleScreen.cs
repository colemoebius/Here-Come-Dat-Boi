using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void Update () {

		if(Input.anyKeyDown){
			Application.LoadLevel("level1");
		}
	}
}
