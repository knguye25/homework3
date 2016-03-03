using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.layer = 11;
			Destroy (gameObject);
		}
	}
}
