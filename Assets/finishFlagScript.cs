using UnityEngine;
using UnityEditor.SceneManagement;
using System.Collections;

public class finishFlagScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Debug.Log("Done");
		}
	}
}
