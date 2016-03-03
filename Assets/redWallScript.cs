using UnityEngine;
using System.Collections;

public class redWallScript : MonoBehaviour {

	private PlayerScript ps;
	void Start () {
		ps = FindObjectOfType<PlayerScript> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.layer == 11) {
			gameObject.layer = 8;
		}
	}
}
