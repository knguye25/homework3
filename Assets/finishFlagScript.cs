using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class finishFlagScript : MonoBehaviour {
	public bool isDone;
	void Start(){
		isDone = false;
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Debug.Log("Done");
			isDone = true;
			SceneManager.LoadScene ("WinScene");
		}
	}
}
