using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
	public float timer;
	public bool isDone;
	public Text timeLable;

	void Start () {
		StartCoroutine ("Countdown", 50);
	}

	void Update () {
	}
	private IEnumerator Countdown(int time){
		while (time > 0) {
			Debug.Log (time--);
			yield return new WaitForSeconds (1);
		}Debug.Log ("Count Done");
	}
}
