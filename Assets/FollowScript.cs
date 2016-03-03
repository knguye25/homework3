using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public PlayerScript thePlayer;
	private Vector3 lastPlayerPos;
	private float distanceXBtw;
	private float distanceYBtw;

	void Start () {
		thePlayer = FindObjectOfType<PlayerScript> ();
		lastPlayerPos = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		distanceXBtw = thePlayer.transform.position.x - lastPlayerPos.x;
		distanceYBtw = thePlayer.transform.position.y - lastPlayerPos.y;
		transform.position = new Vector3 (transform.position.x + distanceXBtw, transform.position.y+distanceYBtw, transform.position.z);
			
		//updating each last position
		lastPlayerPos = thePlayer.transform.position;
	}
}
