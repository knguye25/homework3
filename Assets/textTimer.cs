/*Programmer: Khanh Nguyen*/
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

/* for starting timer and displaying it*/
public class textTimer : MonoBehaviour {

	public float timeLim;
	private Text myText;

	void Start () {
		timeLim = 20f;
		myText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (timeLim > 1) {
			timeLim -= Time.deltaTime;
			myText.text = "Time left: " + Mathf.Round (timeLim);
		} else {
			SceneManager.LoadScene ("LoseScene");
		}
	}
}
