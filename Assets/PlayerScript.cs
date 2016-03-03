using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	/* Public variables*/
	public float speed;
	public bool isGrounded, facingRight;
	public LayerMask groundLayer;

	/* Private variables*/
	private Rigidbody2D playerBody;
	private Collider2D playerCollider;

	void Start () {
		playerBody = GetComponent<Rigidbody2D> ();
		playerCollider = GetComponent<Collider2D> ();
		facingRight = true;
		isGrounded = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		//Debug.Log ("testing key input" + horizontal);
		Movement(horizontal);
		Flip (horizontal);
	}

	void Update(){
		isGrounded = Physics2D.IsTouchingLayers (playerCollider, groundLayer);
		if (Input.GetKey (KeyCode.Space) && isGrounded)
			playerBody.velocity = new Vector2 (playerBody.velocity.x, speed);
	}

	private void Movement(float horizontal){
		playerBody.velocity = new Vector2 (horizontal * speed, playerBody.velocity.y);
	}

	private void Flip(float horizontal){
		if ((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight)) {
			facingRight = !facingRight;
			Vector3 theFlipScale = transform.localScale;
			theFlipScale.x *= -1;
			transform.localScale = theFlipScale;
		}
	}
}
