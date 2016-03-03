using UnityEngine;
using UnityEditor.SceneManagement;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	/* Public variables*/
	public float speed;
	public bool isGrounded, facingRight;
	public LayerMask groundLayer, deathLayer;

	/* Private variables*/
	private Rigidbody2D playerBody;
	private Collider2D playerCollider;
	private Animator playerAnimator;

	void Start () {
		playerBody = GetComponent<Rigidbody2D> ();
		playerCollider = GetComponent<Collider2D> ();
		playerAnimator = GetComponent<Animator> ();
		facingRight = true;
		isGrounded = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		Movement(horizontal,speed);
		if(Input.GetKey(KeyCode.LeftShift))
			Movement(horizontal,speed+10);

		Flip (horizontal);
	}

	void Update(){
		isGrounded = Physics2D.IsTouchingLayers (playerCollider, groundLayer);

		if (Input.GetKey (KeyCode.Space) && isGrounded)
			playerBody.velocity = new Vector2 (playerBody.velocity.x, speed);
		playerAnimator.SetBool ("isGrounded", isGrounded);

		if (Physics2D.IsTouchingLayers (playerCollider, deathLayer))
			Debug.Log ("you died");
		
	}

	private void Movement(float horizontal, float speedVelocity){
		playerBody.velocity = new Vector2 (horizontal * speedVelocity, playerBody.velocity.y);
		playerAnimator.SetFloat ("Speed", Mathf.Abs (horizontal * speedVelocity));
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
