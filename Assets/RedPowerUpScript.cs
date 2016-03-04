/*Programmer: Khanh Nguyen*/
using UnityEngine;
using System.Collections;

public class RedPowerUpScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.layer = 12;
			Destroy (gameObject);
		}
	}
}
