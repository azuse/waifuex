using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoharuControl : MonoBehaviour {

	// Use this for initialization
	protected GameObject Hibiki;
	void Start () {
		Hibiki = GameObject.Find ("hibiki");
	}
	
	// Update is called once per frame
	void Update () {
		if (Hibiki.transform.GetComponent<Animation> ().isPlaying) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Hibiki.transform.GetComponent<Animation> ().Stop ();
			} 
		} else {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				Hibiki.transform.GetComponent<Animation> ().Play ("hibiki_01");
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				Hibiki.transform.GetComponent<Animation> ().Play ("hibiki_02");
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				Hibiki.transform.GetComponent<Animation> ().Play ("hibiki_03");
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				Hibiki.transform.GetComponent<Animation> ().Play ("hibiki_04");
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				Hibiki.transform.GetComponent<Animation> ().Play ("hibiki_05");
			}
		}
	}
}
