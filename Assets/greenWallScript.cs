/*Programmer: Khanh Nguyen*/
using UnityEngine;
using System.Collections;

/*script for when player collide against green wall/platform*/
public class greenWallScript : MonoBehaviour {

	private PlayerScript ps;
	void Start () {
		ps = FindObjectOfType<PlayerScript> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.layer == 12) {
			gameObject.layer = 8;
		}
	}
}
