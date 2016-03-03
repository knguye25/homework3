using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayAgain : MonoBehaviour {
	public void restartLvl(){
		Debug.Log("restarting");
		SceneManager.LoadScene ("GameScene");
	}

	public void quitLvl(){
		Debug.Log ("quit");
		Application.Quit ();
	}

	public void helpLvl(){
		Debug.Log ("help");
		SceneManager.LoadScene ("HelpScene");
	}

	public void titleLvl(){
		Debug.Log ("Back to Title");
		SceneManager.LoadScene ("TitleScene");
	}
}
