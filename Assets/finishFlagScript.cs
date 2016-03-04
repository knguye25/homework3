/*Programmer: Khanh Nguyen*/
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/*for flag to end game if player got to finish line*/
public class finishFlagScript : MonoBehaviour {
	public bool isDone;
	void Start(){
		isDone = false;
	}

	/*checking for when player touch flag*/
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Debug.Log("Done");
			isDone = true;
			SceneManager.LoadScene ("WinScene");
		}
	}
}
